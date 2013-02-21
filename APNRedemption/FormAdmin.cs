using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using DAL;
using Models;

namespace APNRedemption
{
    public partial class FormAdmin : Form
    {
        public static int current_apn_id = 0;
        public static int current_list_apn_selectindex = 0;
        public static int current_user_id = 0;
        public static int current_list_user_selectindex = 0;
        public static int current_vpn_id = 0;
        public static int current_list_vpn_selectindex = 0;
        public static VPN current_vpn;
        public static APN current_apn;

        public FormAdmin()
        {
            InitializeComponent();

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
        public void bindAPN()
        {

            string sqlStr = "SELECT * FROM APN ORDER BY ID asc";
            object tmp = this.list_apn.SelectedValue;
            DataTable dt = DB.dataTable(sqlStr);
            this.list_apn.DataSource = dt;
            this.list_apn.DisplayMember = "apn_name";
            this.list_apn.ValueMember = "ID";
            if (tmp != null) this.list_apn.SelectedValue = tmp;

            tmp = this.user_apn.SelectedValue;
            DataTable dt1 = DB.dataTable(sqlStr);
            user_apn.DataSource = dt1;
            user_apn.DisplayMember = "apn_name";
            user_apn.ValueMember = "id";
            if (tmp != null) this.user_apn.SelectedValue = tmp;
        }

        public void bindVPN()
        {
            // lb_vpn
            string sqlStr = "SELECT * FROM VPN ORDER BY ID asc";
            object tmp = this.lb_vpn.SelectedValue;
            DataTable dt = DB.dataTable(sqlStr);
            this.lb_vpn.DataSource = dt;
            this.lb_vpn.DisplayMember = "vpn_name";
            this.lb_vpn.ValueMember = "ID";
            if (tmp != null) this.lb_vpn.SelectedValue = tmp;
            // vpn1
            tmp = this.cb_apn_vpn1_id.SelectedValue;
            DataTable dt1 = DB.dataTable(sqlStr);
            DataRow row1 = dt1.NewRow();
            row1["vpn_name"] = "---请选择---";
            row1["id"] = 0;
            dt1.Rows.InsertAt(row1, 0);
            this.cb_apn_vpn1_id.DataSource = dt1;
            this.cb_apn_vpn1_id.DisplayMember = "vpn_name";
            this.cb_apn_vpn1_id.ValueMember = "ID";
            if (tmp != null) this.cb_apn_vpn1_id.SelectedValue = tmp;
            //// vpn2
            //tmp = this.cb_apn_vpn2_id.SelectedValue;
            //DataTable dt2 = DB.dataTable(sqlStr);
            //DataRow row2 = dt2.NewRow();
            //row2["vpn_name"] = "---请选择---";
            //row2["id"] = 0;
            //dt2.Rows.InsertAt(row2, 0);
            //this.cb_apn_vpn2_id.DataSource = dt2;
            //this.cb_apn_vpn2_id.DisplayMember = "vpn_name";
            //this.cb_apn_vpn2_id.ValueMember = "ID";
            //if (tmp != null) this.cb_apn_vpn2_id.SelectedValue = tmp;
        }
        public void bindUser()
        {
            this.userTableAdapter.Fill(this.arAPN.User);
            if (this.arAPN.User.Rows.Count > 0)
            {
                this.list_user.SelectedIndex = current_list_user_selectindex;
            }
            else
            {
                btn_user_save.Enabled = false;
                tab_user.Hide();
            }

            clb_apn_user.DataSource = this.arAPN.User;
            clb_apn_user.DisplayMember = "username";
            clb_apn_user.ValueMember = "id";
        }
        private BindingList<KeyValuePair<string, string>> m_items = new BindingList<KeyValuePair<string, string>>();
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            bindVPN();
            bindAPN();
            bindUser();
            genScript();
            // apn static combo
            cb_apn_is_static.DisplayMember = "Key";
            cb_apn_is_static.ValueMember = "Value";

            m_items.Add(new KeyValuePair<string, string>("---请选择---", ""));
            m_items.Add(new KeyValuePair<string, string>("静态", "静态"));
            m_items.Add(new KeyValuePair<string, string>("动态", "动态"));
            cb_apn_is_static.DataSource = m_items;

            // script
            try
            {
                FileStream fs = new FileStream("Script.txt", FileMode.Open, FileAccess.Read);
                StreamReader m_streamReader = new StreamReader(fs);
                this.tb_script.Text = m_streamReader.ReadToEnd();
                m_streamReader.Close();
                fs.Close();
            }
            catch
            {
            }
            finally
            {
            }

        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            string tmp_name = "新建用户";
            string user_name = tmp_name;
            string sqlStr = "SELECT count(*) FROM [user] WHERE [username] = '" + tmp_name + "'";
            int count = Int16.Parse(DB.excuteScalar(sqlStr));
            int i = 0;
            while (count > 0)
            {
                i += 1;
                user_name = tmp_name + " " + i.ToString();
                sqlStr = "SELECT count(*) FROM APN WHERE apn = '" + user_name + "'";
                count = Int16.Parse(DB.excuteScalar(sqlStr));
            }
            sqlStr = "INSERT INTO [USER](username) VALUES('" + user_name + "')";
            DB.excuteSql(sqlStr);
            this.userTableAdapter.Fill(this.arAPN.User);
            list_user.SelectedIndex = list_user.Items.Count - 1;
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
        public void bind_apn_set(APN apn)
        {
            current_apn = apn;
            this.tb_apn_apn_name.Text = apn.apn_name;
            this.tb_apn_contact.Text = apn.contact;
            this.tb_apn_ggsn.Text = apn.ggsn;
            this.tb_apn_ggsn_gnif.Text = apn.ggsn_gnif;
            this.tb_apn_memo.Text = apn.memo;
            this.tb_apn_tunnel_name.Text = apn.tunnel_name;
            this.tb_apn_sim_ip.Text = apn.sim_ip;
            this.tb_apn_serverip.Text = apn.serverip;
            this.cb_apn_is_static.SelectedValue = apn.is_static;
            this.cb_apn_vpn1_id.SelectedValue = apn.vpn1_id;
            if (apn.vpn1 != null)
            {
                this.lb_apn_vpn_source.Text = apn.vpn1.source;
                this.lb_apn_vpn_destination.Text = apn.vpn1.destination;
                this.lb_apn_vpn_ipaddress.Text = apn.vpn1.ipaddress;
                this.lb_apn_vpn_route.Text = apn.vpn1.route;

                this.lb_apn_vpn_source1.Text = apn.vpn1.source1;
                this.lb_apn_vpn_destination1.Text = apn.vpn1.destination1;
                this.lb_apn_vpn_ipaddress1.Text = apn.vpn1.ipaddress1;
                this.lb_apn_vpn_route1.Text = apn.vpn1.route1;
            }
            //this.cb_apn_vpn2_id.SelectedValue = apn.vpn2_id;
            this.tb_apn_apn_name.Focus();
            this.btn_apn_save.Enabled = false;
        }
        private void list_apn_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)list_apn.SelectedItem;
            if (drv != null)
            {
                string apn_id = drv["ID"].ToString();
                bind_apn_set(ModelAPN.Get(Int16.Parse(apn_id)));
            }

        }
        private void list_apn_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                list_apn.SelectedIndex = list_apn.IndexFromPoint(e.X, e.Y);
                m_apn.Show(Control.MousePosition.X, Control.MousePosition.Y);
            }
        }

        private void list_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)list_user.SelectedItem;
            if (drv != null)
            {
                string _id = drv["ID"].ToString();
                string sqlStr = "SELECT * FROM [USER] WHERE ID=" + _id;
                OleDbDataReader dr = DB.dataReader(sqlStr);
                if (dr.Read())
                {
                    tb_username.Text = dr["username"].ToString();
                    tb_password.Text = dr["password"].ToString();
                    if (dr["usertype"].ToString() == "admin")
                    {
                        cb_admin.Checked = true;
                    }
                    else
                    {
                        cb_admin.Checked = false;
                    }
                }
                dr.Close();
                sqlStr = "SELECT * FROM [apn_user] WHERE user_id=" + _id;
                DataTable dt = DB.dataTable(sqlStr);

                for (int i = 0; i < clb_apn_user.Items.Count; i++)
                {
                    clb_apn_user.SetItemChecked(i, false);
                    DataRowView item = (DataRowView)clb_apn_user.Items[i];
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (item["id"].Equals(dt.Rows[j]["user_id"]))
                        {
                            clb_apn_user.SetItemChecked(i, true);
                            break;
                        }
                    }
                }

                current_user_id = Int16.Parse(_id);
                current_list_user_selectindex = list_user.SelectedIndex;
                if (!tab_user.Visible) tab_user.Show();
                if (!btn_user_save.Enabled) btn_user_save.Enabled = true;
                tb_username.Focus();
            }
        }

        private void btn_user_save_Click(object sender, EventArgs e)
        {
            if (current_user_id > 0)
            {
                string updateSql = "UPDATE [user] SET [username]=@username, [password]=@password, [usertype]=@usertype WHERE id=@id";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = updateSql;
                string usertype = "";
                if (cb_admin.Checked == true)
                {
                    usertype = "admin";
                }
                cmd.Parameters.AddWithValue("@username", this.tb_username.Text);
                cmd.Parameters.AddWithValue("@password", this.tb_password.Text);
                cmd.Parameters.AddWithValue("@usertype", usertype);
                cmd.Parameters.AddWithValue("@id", current_user_id);
                DB.excuteSql(cmd);

                for (int i = 0; i < user_apn.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)user_apn.Items[i];
                    string sqlStr = "SELECT Count(*) FROM apn_user WHERE apn_id = " + item["id"] + " and user_id =  " + current_user_id;
                    int c = Int16.Parse(DB.excuteScalar(sqlStr));
                    if (this.user_apn.CheckedItems.IndexOf(item) >= 0 && c == 0)
                    {
                        sqlStr = "INSERT INTO apn_user(apn_id, user_id) VALUES(" + item["id"] + ", " + current_user_id + ") ";
                        DB.excuteSql(sqlStr);
                    }
                    else if (this.clb_apn_user.CheckedItems.IndexOf(item) < 0 && c > 0)
                    {
                        sqlStr = "DELETE FROM apn_user WHERE apn_id = " + item["id"] + " and user_id =  " + current_user_id;
                        DB.excuteSql(sqlStr);
                    }
                }

                this.userTableAdapter.Fill(this.arAPN.User);
                this.list_user.SelectedIndex = current_list_user_selectindex;


                MessageBox.Show("保存成功");
            }
        }

        private void btn_add_vpn_Click(object sender, EventArgs e)
        {
            this.btn_add_vpn.Enabled = false;
            Application.DoEvents();
            string tmp_name = "vpn";
            string vpn_name = tmp_name;
            string sqlStr = "SELECT count(*) FROM VPN WHERE vpn_name = '" + tmp_name + "'";
            int count = Int16.Parse(DB.excuteScalar(sqlStr));
            int i = 0;
            while (count > 0)
            {
                i += 1;
                vpn_name = tmp_name + i.ToString();
                sqlStr = "SELECT count(*) FROM vpn WHERE vpn_name = '" + vpn_name + "'";
                count = Int16.Parse(DB.excuteScalar(sqlStr));
            }
            sqlStr = "INSERT INTO VPN(vpn_name) VALUES('" + vpn_name + "')";
            DB.excuteSql(sqlStr);
            current_vpn = null;
            bindVPN();
            this.lb_vpn.SelectedIndex = this.lb_vpn.Items.Count - 1;
            this.btn_add_vpn.Enabled = true;
        }

        private void btn_add_apn_Click(object sender, EventArgs e)
        {
            this.btn_add_apn.Enabled = false;
            Application.DoEvents();
            string tmp_name = "apn";
            string apn_name = tmp_name;
            string sqlStr = "SELECT count(*) FROM APN WHERE apn_name = '" + tmp_name + "'";
            int count = Int16.Parse(DB.excuteScalar(sqlStr));
            int i = 0;
            while (count > 0)
            {
                i += 1;
                apn_name = tmp_name + " " + i.ToString();
                sqlStr = "SELECT count(*) FROM APN WHERE apn_name = '" + apn_name + "'";
                count = Int16.Parse(DB.excuteScalar(sqlStr));
            }
            sqlStr = "INSERT INTO APN(apn_name, vpn1_id, vpn2_id) VALUES('" + apn_name + "', 0,0)";
            DB.excuteSql(sqlStr);
            current_apn = null;
            bindAPN();
            this.list_apn.SelectedIndex = this.list_apn.Items.Count - 1;
            this.btn_add_apn.Enabled = true;
        }

        public void bind_vpn_set(VPN vpn)
        {
            current_vpn = vpn;
            this.tb_vpn_vpn_name.Text = current_vpn.vpn_name;
            this.tb_vpn_source.Text = current_vpn.source;
            this.tb_vpn_destination.Text = current_vpn.destination;
            this.tb_vpn_ipaddress.Text = current_vpn.ipaddress;
            this.tb_vpn_route.Text = current_vpn.route;
            this.tb_vpn_source1.Text = current_vpn.source1;
            this.tb_vpn_destination1.Text = current_vpn.destination1;
            this.tb_vpn_ipaddress1.Text = current_vpn.ipaddress1;
            this.tb_vpn_route1.Text = current_vpn.route1;
            this.tb_vpn_memo.Text = current_vpn.memo;
            tb_vpn_vpn_name.Focus();
            this.btn_vpn_save.Enabled = false;

        }
        private void lb_vpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.lb_vpn.SelectedItem;
            if (drv != null)
            {
                string vpn_id = drv["ID"].ToString();
                bind_vpn_set(ModelVPN.Get(Int16.Parse(vpn_id)));
            }
        }
        public void vpn_changed(object sender, EventArgs e)
        {
            if (current_vpn != null && current_vpn.id > 0)
            {
                changed(sender, e, current_vpn);
                btn_vpn_save.Enabled = true;
            }
        }
        public void apn_changed(object sender, EventArgs e)
        {
            if (current_apn != null && current_apn.id > 0)
            {
                changed(sender, e, current_apn);
                btn_apn_save.Enabled = true;
            }
        }
        public void changed(object sender, EventArgs e, object current)
        {
            Type t = sender.GetType();
            if (t.Name == "TextBox")
            {
                TextBox tb = (TextBox)sender;
                string attrname = tb.Name.Substring(7);
                current.GetType().GetProperty(attrname).SetValue(current, tb.Text, null);
            }
            else if (t.Name == "ComboBox")
            {
                ComboBox cb = (ComboBox)sender;
                string attrname = cb.Name.Substring(7);
                current.GetType().GetProperty(attrname).SetValue(current, cb.SelectedValue, null);
            }
            current.GetType().GetProperty("is_modified").SetValue(current, true, null);
        }

        private void btn_vpn_save_Click(object sender, EventArgs e)
        {
            current_vpn.save();
            bindVPN();
            btn_vpn_save.Enabled = false;
        }


        private void btn_apn_save_Click(object sender, EventArgs e)
        {

            current_apn.save();
            bindAPN();
            btn_apn_save.Enabled = false;
        }

        private void btn_vpn_preview_Click(object sender, EventArgs e)
        {
            if (current_vpn.validate())
            {
                FormScript f = new FormScript(current_vpn.getScript());
                f.Show();
            }
            else
            {
                MessageBox.Show(current_vpn.err);
            }
        }

        private void btn_apn_delete_Click(object sender, EventArgs e)
        {
            current_apn.delete();
            bindAPN();
        }

        private void btn_apn_preview_Click(object sender, EventArgs e)
        {
            if (current_apn.validate())
            {
                FormScript f = new FormScript(current_apn.getScript());
                f.Show();
            }
            else
            {
                MessageBox.Show(current_apn.err);
            }

        }
        public void genScript()
        {
            string script = "";
            foreach (DataRowView drv in lb_vpn.Items)
            {
                int id = int.Parse(drv.Row["id"].ToString());
                VPN vpn = ModelVPN.Get(id);
                try
                {
                    script += vpn.getScript();
                }
                catch (Exception ex)
                {
                }
                script += "\r\n";
            }
            foreach (DataRowView drv in list_apn.Items)
            {
                int id = int.Parse(drv.Row["id"].ToString());
                APN apn = ModelAPN.Get(id);
                try
                {
                    script += apn.getScript();
                }
                catch (Exception ex)
                {
                }
                script += "\r\n";
            }
            StreamWriter sr;
            string FILE_NAME = "Script.txt";
            if (File.Exists(FILE_NAME)) //如果文件存在,则创建File.AppendText对象
            {
                sr = File.AppendText(FILE_NAME);
            }
            else    //如果文件不存在,则创建File.CreateText对象
            {
                sr = File.CreateText(FILE_NAME);
            }
            sr.WriteLine(script);
            sr.Close();
            this.tb_script.Text = script;
        }
        private void btn_script_gen_Click(object sender, EventArgs e)
        {
            genScript();
        }

        private void btn_apn_dns_Click(object sender, EventArgs e)
        {
            if (current_apn.validate())
            {
                FormScript f = new FormScript(current_apn.getDNSScript());
                f.Show();
            }
            else
            {
                MessageBox.Show(current_apn.err);
            }
        }

        private void btn_script_run_Click(object sender, EventArgs e)
        {
            if (this.tb_script.Text != "")
            {
                FormScript f = new FormScript(this.tb_script.Text);
                f.Show();
            }
            else
            {
                MessageBox.Show("脚本为空，请确定已经配置有vpn,apn，并更新脚本");
            }
        }

        private void cb_apn_vpn1_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vpn_id = 0;
            try
            {
                vpn_id = int.Parse(this.cb_apn_vpn1_id.SelectedValue.ToString());
            }
            catch { }

            VPN vpn1 = ModelVPN.Get(vpn_id);
            try
            {
                vpn1.validate();
            }
            catch { }
            if (vpn1 != null)
            {
                this.lb_apn_vpn_source.Text = vpn1.source;
                this.lb_apn_vpn_destination.Text = vpn1.destination;
                this.lb_apn_vpn_ipaddress.Text = vpn1.ipaddress;
                this.lb_apn_vpn_route.Text = vpn1.route;

                this.lb_apn_vpn_source1.Text = vpn1.source1;
                this.lb_apn_vpn_destination1.Text = vpn1.destination1;
                this.lb_apn_vpn_ipaddress1.Text = vpn1.ipaddress1;
                this.lb_apn_vpn_route1.Text = vpn1.route1;

                this.tb_apn_tunnel_name.Text = vpn1.tunnel_id;
            }


        }

        private void btn_script_import_Click(object sender, EventArgs e)
        {
            FormInputScript f = new FormInputScript();
            f.Show();
        }
    }
}
