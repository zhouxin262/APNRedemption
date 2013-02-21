namespace APNRedemption
{
    partial class FormScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_script = new System.Windows.Forms.TextBox();
            this.tb_script_password = new System.Windows.Forms.TextBox();
            this.tb_script_username = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_script_run = new System.Windows.Forms.Button();
            this.tb_script_port = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_script_ip = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_script
            // 
            this.tb_script.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_script.Location = new System.Drawing.Point(0, 0);
            this.tb_script.Multiline = true;
            this.tb_script.Name = "tb_script";
            this.tb_script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_script.Size = new System.Drawing.Size(784, 530);
            this.tb_script.TabIndex = 0;
            this.tb_script.WordWrap = false;
            // 
            // tb_script_password
            // 
            this.tb_script_password.Location = new System.Drawing.Point(493, 538);
            this.tb_script_password.Name = "tb_script_password";
            this.tb_script_password.Size = new System.Drawing.Size(148, 21);
            this.tb_script_password.TabIndex = 19;
            this.tb_script_password.Text = "zx880918";
            this.tb_script_password.UseSystemPasswordChar = true;
            // 
            // tb_script_username
            // 
            this.tb_script_username.Location = new System.Drawing.Point(334, 538);
            this.tb_script_username.Name = "tb_script_username";
            this.tb_script_username.Size = new System.Drawing.Size(118, 21);
            this.tb_script_username.TabIndex = 18;
            this.tb_script_username.Text = "xin";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(458, 541);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 17;
            this.label19.Text = "密码：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(275, 541);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 16;
            this.label18.Text = "用户名：";
            // 
            // btn_script_run
            // 
            this.btn_script_run.Location = new System.Drawing.Point(647, 536);
            this.btn_script_run.Name = "btn_script_run";
            this.btn_script_run.Size = new System.Drawing.Size(125, 23);
            this.btn_script_run.TabIndex = 15;
            this.btn_script_run.Text = "开始运行";
            this.btn_script_run.UseVisualStyleBackColor = true;
            this.btn_script_run.Click += new System.EventHandler(this.btn_script_run_Click);
            // 
            // tb_script_port
            // 
            this.tb_script_port.Location = new System.Drawing.Point(230, 538);
            this.tb_script_port.Name = "tb_script_port";
            this.tb_script_port.Size = new System.Drawing.Size(39, 21);
            this.tb_script_port.TabIndex = 14;
            this.tb_script_port.Text = "65505";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 541);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "端口：";
            // 
            // tb_script_ip
            // 
            this.tb_script_ip.Location = new System.Drawing.Point(71, 538);
            this.tb_script_ip.Name = "tb_script_ip";
            this.tb_script_ip.Size = new System.Drawing.Size(102, 21);
            this.tb_script_ip.TabIndex = 12;
            this.tb_script_ip.Text = "255.255.255.255";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 541);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "IP地址：";
            // 
            // FormScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tb_script_password);
            this.Controls.Add(this.tb_script_username);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_script_run);
            this.Controls.Add(this.tb_script_port);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_script_ip);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_script);
            this.Name = "FormScript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "脚本";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_script;
        private System.Windows.Forms.TextBox tb_script_password;
        private System.Windows.Forms.TextBox tb_script_username;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_script_run;
        private System.Windows.Forms.TextBox tb_script_port;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_script_ip;
        private System.Windows.Forms.Label label15;
    }
}