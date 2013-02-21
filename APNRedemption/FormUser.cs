using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Text.RegularExpressions;
using Models;
using DAL;
using Utils;


namespace APNRedemption
{
    public partial class FormUser : Form
    {
        public int current_user_id = 0;
        public static int current_apn_id = 0;
        public static int current_list_apn_selectindex = 0;
        public APN current_apn;

        public FormUser()
        {
            InitializeComponent();
        }
        public void BindApn()
        {
            string sqlStr = "SELECT * FROM apn WHERE id in (SELECT apn_id FROM apn_user WHERE user_id = " + current_user_id + ")";
            DataTable dt = DB.dataTable(sqlStr);
            this.list_apn.DataSource = dt;
            this.list_apn.DisplayMember = "apn";
            this.list_apn.ValueMember = "id";
            this.list_apn.SelectedIndex = 0;
        }
        public void BindApn(int index)
        {
            string sqlStr = "SELECT * FROM apn WHERE id in (SELECT apn_id FROM apn_user WHERE user_id = " + current_user_id + ")";
            DataTable dt = DB.dataTable(sqlStr);
            this.list_apn.DataSource = dt;
            this.list_apn.DisplayMember = "apn";
            this.list_apn.ValueMember = "id";
            this.list_apn.SelectedIndex = index;
        }
        public void BindDeviceBrand()
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo TheFolder = new DirectoryInfo(path+"\\scripts\\");
            foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
            {
                this.cb_device_brand.Items.Add(NextFolder.Name);
            }
            this.lb_device_model.Visible = false;
            this.cb_device_model.Visible = false;
        }

        public void enter_filter(object sender, EventArgs e)
        {
            TextBox _tb = (TextBox)sender;
            if (_tb.Text == "过滤")
            {
                _tb.Text = "";
            }
        }

        private void leave_filter(object sender, EventArgs e)
        {
            TextBox _tb = (TextBox)sender;
            if (_tb.Text == "")
            {
                _tb.Text = "过滤";
            }

        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“arAPN.Apn”中。您可以根据需要移动或删除它。
            BindDeviceBrand();
            BindApn();
            this.cb_port_com.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if(this.cb_port_com.Items.Count > 0)this.cb_port_com.SelectedItem = this.cb_port_com.Items[0];
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void SetCB(object obj, string value)
        {
            ComboBox cb = (ComboBox)obj;
            if (value == null || value == "")
            {
                cb.SelectedIndex = 0;
            }
            else
            {
                cb.SelectedItem = value;
            }
        }
        private void list_apn_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)list_apn.SelectedItem;
            if (drv != null)
            {
                string apn_id = drv["ID"].ToString();
                current_apn_id = Int16.Parse(apn_id);
                current_list_apn_selectindex = list_apn.SelectedIndex;
                current_apn = ModelAPN.Get(current_apn_id);
                //tb_apn.Text = current_apn.apn;
                //tb_sim.Text = current_apn.sim;
                //SetCB(cb_is_static, current_apn.is_static);
                //SetCB(cb_is_created, current_apn.is_created);
                //tb_pub.Text = current_apn.pub;
                //tb_to_pub.Text = current_apn.to_pub;
                //tb_pri.Text = current_apn.pri;
                //tb_to_pri.Text = current_apn.to_pri;
                //tb_to_server.Text = current_apn.to_server;
                //tb_iggsn.Text = current_apn.iggsn;
                tb_memo.Text = current_apn.memo;

                string sqlStr = "SELECT path FROM [apn_device] WHERE apn_id=" + apn_id;
                string path = DB.excuteScalar(sqlStr);
                try
                {
                    string[] device = path.Split('\\');
                    string brand = device[0];
                    string model = device[1];
                    cb_device_brand.SelectedItem = brand;
                    BindDeviceModel();
                    cb_device_model.SelectedItem = model;
                }
                catch (Exception ex)
                {
                    cb_device_brand.SelectedItem = null;
                    cb_device_model.SelectedItem = null;
                    cb_device_brand.Text = null;
                    cb_device_model.Text = null;
                    tb_template.Text = "";
                    tb_script.Text = "";
                }
                finally
                {

                }
                
                if (!tab_apn.Visible) tab_apn.Show();
                if (btn_apn_save.Enabled) btn_apn_save.Enabled = false;
                tb_apn.Focus();
            }          
        }
        public void changed(object sender, EventArgs e)
        {
            Type t = sender.GetType();
            if (t.Name == "TextBox")
            {
                try
                {
                    TextBox tb = (TextBox)sender;
                    string attrname = tb.Name.Substring(3);
                    if (current_apn.GetType().GetProperty(attrname).GetValue(current_apn, null).ToString() != tb.Text)
                    {
                        current_apn.GetType().GetProperty(attrname).SetValue(current_apn, tb.Text,null);
                        current_apn.is_modified = true;
                        btn_apn_save.Enabled = true;
                        GenScript();
                    }
                }
                catch (Exception ex)
                {
                }
            }
            else if (t.Name == "ComboBox")
            {
                try
                {
                    ComboBox cb = (ComboBox)sender;
                    string attrname = cb.Name.Substring(3);
                    if (current_apn.GetType().GetProperty(attrname).GetValue(current_apn, null).ToString() != cb.SelectedItem.ToString())
                    {
                        current_apn.GetType().GetProperty(attrname).SetValue(current_apn, cb.SelectedItem.ToString(), null);
                        current_apn.is_modified = true;
                        btn_apn_save.Enabled = true;
                        GenScript();
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void btn_apn_save_Click(object sender, EventArgs e)
        {
            if (current_apn != null)
            {
                current_apn.save();

                try
                {
                    string sqlStr = "SELECT Count(*) FROM apn_device WHERE apn_id = " + current_apn_id;
                    int count = Int16.Parse(DB.excuteScalar(sqlStr));
                    if (count == 0)
                    {
                        sqlStr = "INSERT INTO apn_device(apn_id, path) VALUES(" + current_apn_id + ", '" + this.cb_device_brand.SelectedItem.ToString() + "\\" + this.cb_device_model.SelectedItem.ToString() + "')";
                        DB.excuteSql(sqlStr);
                    }
                    else
                    {
                        sqlStr = "UPDATE apn_device SET path = '" + this.cb_device_brand.SelectedItem.ToString() + "\\" + this.cb_device_model.SelectedItem.ToString() + "' WHERE apn_id=" + current_apn_id;
                        DB.excuteSql(sqlStr);
                    }
                }
                catch (Exception ex)
                {
                }
                    

                BindApn(current_list_apn_selectindex);
                //this.list_apn.SelectedIndex = current_list_apn_selectindex;
                btn_apn_save.Enabled = false;

                MessageBox.Show("保存成功");
            }
        }

        public void BindDeviceModel()
        {
            this.cb_device_model.Items.Clear();
            this.cb_device_model.SelectedItem = null;
            try
            {
                string path = Directory.GetCurrentDirectory();
                string brand_path = path + "\\scripts\\" + this.cb_device_brand.SelectedItem.ToString() + "\\";
                DirectoryInfo TheFolder = new DirectoryInfo(brand_path);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                {
                    this.cb_device_model.Items.Add(NextFile.Name.Substring(0,NextFile.Name.Length-NextFile.Extension.Length));
                }
                this.lb_device_model.Visible = true;
                this.cb_device_model.Visible = true;
            }
            catch (Exception ex)
            {
                this.lb_device_model.Visible = false;
                this.cb_device_model.Visible = false;
            }
            finally
            {
            }
            
        }
        private void cb_device_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDeviceModel();
        }

        public void ReadScripts()
        {
            tb_template.Text = "";
            tb_script.Text = "";
            string path = Directory.GetCurrentDirectory();
            string brand_path = path + "\\scripts\\" + this.cb_device_brand.SelectedItem.ToString() + "\\";
            StreamReader sr = new StreamReader(brand_path + this.cb_device_model.SelectedItem.ToString() + ".txt");
            //StreamReader sr = new StreamReader("TestFile.txt",Encoding.GetEncoding("GB2312"))
            ///GBK
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                tb_template.Text += line.ToString()+"\r\n";
            }
            GenScript();

        }
        public void GenScript()
        {
            string script = tb_template.Text;
            Type t = current_apn.GetType();
            foreach (PropertyInfo pi in t.GetProperties())
            {
                object value = pi.GetValue(current_apn, null);
                string name = pi.Name;
                script = script.Replace("{{" + name + "}}", value.ToString());
            }
            tb_script.Text = script;
        }
        private void cb_device_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadScripts();
            btn_apn_save.Enabled = true;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            tb_run.Text = "";
            tab_apn.SelectedIndex = 2;
            //string[] commands = Regex.Split(tb_script.Text, "\r\n", RegexOptions.IgnoreCase);
            //foreach (string command in commands)
            //{
            //    tb_run.Text += command.ToString() + "\r\n";
            //    Application.DoEvents(); 
            //    Thread.Sleep(1000);
            //}
        }

        private void btn_run_telnet_Click(object sender, EventArgs e)
        {
            tb_result.Text = "";
            string ipTelnet = tb_ip_telnet.Text;
            Int16 portTelnet = Int16.Parse(tb_port_telnet.Text);
            Telnet p = new Telnet(ipTelnet, portTelnet, 50); 
            if (p.Connect() == false)
            {
                tb_result.Text += "连接失败\n";
                return;
            }
            p.WaitFor("login:");
            p.Send(tb_username_telnet.Text);
            p.WaitFor("password:");
            p.Send(tb_password_telnet.Text);
            p.WaitFor(">");
            tb_result.Text += p.WorkingData + "\n";
            p.Send("dir\n");
            Application.DoEvents(); 
            Thread.Sleep(1000);
            //Console.WriteLine(p.SessionLog);
            tb_result.Text += p.WorkingData + "\n";
        }
    }
}
