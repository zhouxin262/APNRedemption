using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace APNRedemption
{
    public partial class FormScript : Form
    {
        public FormScript()
        {
            InitializeComponent();
        }
        public FormScript(string script)
        {
            InitializeComponent();
            this.tb_script.Text = script;
        }

        private void btn_script_run_Click(object sender, EventArgs e)
        {
            //test
            string script = this.tb_script.Text;
            tb_script.Text = "0\t开始执行...\r\n";

            int i = 0;
            foreach (string line in script.Replace("\r\n", ";").Split(';'))
            {
                i++;
                this.tb_script.Text += i.ToString() + '\t' + line + "\r\n";
                Application.DoEvents();
                Thread.Sleep(1000);
            }


            tb_script.Text += (i+1).ToString() + "\t执行完毕...\r\n";

            //deploy
            //string script = this.tb_script.Text;
            //tb_script.Text = "开始执行...";
            //string ip = this.tb_script_ip.Text;
            //Int16 portTelnet = Int16.Parse(this.tb_script_port.Text);
            //Telnet p = new Telnet(ip, portTelnet, 50);
            //if (p.Connect() == false)
            //{
            //    tb_script.Text += "连接失败\n";
            //    return;
            //}
            //p.WaitFor("login:");
            //p.Send(this.tb_script_username.Text);
            //p.WaitFor("password:");
            //p.Send(this.tb_script_password.Text);
            //p.WaitFor(">");
            //foreach(string line in script.Replace("\r\n", ";").Split(';')){
            //    p.Send(line);
            //    Application.DoEvents();
            //    Thread.Sleep(1000);
            //    this.tb_script.Text += p.WorkingData + "\r\n";
            //}
            //Console.WriteLine(p.SessionLog);
        }
    }
}
