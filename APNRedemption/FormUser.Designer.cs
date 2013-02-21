namespace APNRedemption
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_apn_filter = new System.Windows.Forms.TextBox();
            this.list_apn = new System.Windows.Forms.ListBox();
            this.btn_apn_cancel = new System.Windows.Forms.Button();
            this.btn_apn_save = new System.Windows.Forms.Button();
            this.tab_apn = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_is_created = new System.Windows.Forms.ComboBox();
            this.tb_memo = new System.Windows.Forms.TextBox();
            this.tb_sim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_iggsn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_to_server = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_to_pri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_to_pub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pub = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_apn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_is_static = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_run = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_template = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_script = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_device_model = new System.Windows.Forms.Label();
            this.cb_device_brand = new System.Windows.Forms.ComboBox();
            this.cb_device_model = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_password_telnet = new System.Windows.Forms.TextBox();
            this.tb_username_telnet = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_run_telnet = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.tb_port_telnet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_ip_telnet = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_rate_com = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_port_com = new System.Windows.Forms.ComboBox();
            this.tb_run = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_apn.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_apn_cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_apn_save);
            this.splitContainer1.Panel2.Controls.Add(this.tab_apn);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_apn_filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.list_apn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 562);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tb_apn_filter
            // 
            this.tb_apn_filter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_apn_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_apn_filter.Location = new System.Drawing.Point(4, 4);
            this.tb_apn_filter.Name = "tb_apn_filter";
            this.tb_apn_filter.Size = new System.Drawing.Size(157, 16);
            this.tb_apn_filter.TabIndex = 999;
            this.tb_apn_filter.Text = "过滤";
            this.tb_apn_filter.Enter += new System.EventHandler(this.enter_filter);
            this.tb_apn_filter.Leave += new System.EventHandler(this.leave_filter);
            // 
            // list_apn
            // 
            this.list_apn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_apn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_apn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_apn.FormattingEnabled = true;
            this.list_apn.ItemHeight = 14;
            this.list_apn.Location = new System.Drawing.Point(4, 27);
            this.list_apn.Name = "list_apn";
            this.list_apn.Size = new System.Drawing.Size(157, 531);
            this.list_apn.TabIndex = 0;
            this.list_apn.SelectedIndexChanged += new System.EventHandler(this.list_apn_SelectedIndexChanged);
            // 
            // btn_apn_cancel
            // 
            this.btn_apn_cancel.Location = new System.Drawing.Point(484, 509);
            this.btn_apn_cancel.Name = "btn_apn_cancel";
            this.btn_apn_cancel.Size = new System.Drawing.Size(124, 40);
            this.btn_apn_cancel.TabIndex = 8;
            this.btn_apn_cancel.Text = "取消";
            this.btn_apn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_apn_save
            // 
            this.btn_apn_save.Location = new System.Drawing.Point(353, 509);
            this.btn_apn_save.Name = "btn_apn_save";
            this.btn_apn_save.Size = new System.Drawing.Size(124, 40);
            this.btn_apn_save.TabIndex = 12;
            this.btn_apn_save.Text = "保存";
            this.btn_apn_save.UseVisualStyleBackColor = true;
            this.btn_apn_save.Click += new System.EventHandler(this.btn_apn_save_Click);
            // 
            // tab_apn
            // 
            this.tab_apn.Controls.Add(this.tabPage3);
            this.tab_apn.Controls.Add(this.tabPage4);
            this.tab_apn.Controls.Add(this.tabPage1);
            this.tab_apn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_apn.Location = new System.Drawing.Point(0, 0);
            this.tab_apn.Name = "tab_apn";
            this.tab_apn.SelectedIndex = 0;
            this.tab_apn.Size = new System.Drawing.Size(614, 497);
            this.tab_apn.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cb_is_created);
            this.tabPage3.Controls.Add(this.tb_memo);
            this.tabPage3.Controls.Add(this.tb_sim);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tb_iggsn);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.tb_to_server);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tb_to_pri);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tb_pri);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tb_to_pub);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tb_pub);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tb_apn);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cb_is_static);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(606, 469);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_is_created
            // 
            this.cb_is_created.FormattingEnabled = true;
            this.cb_is_created.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cb_is_created.Location = new System.Drawing.Point(184, 121);
            this.cb_is_created.Name = "cb_is_created";
            this.cb_is_created.Size = new System.Drawing.Size(414, 22);
            this.cb_is_created.TabIndex = 4;
            this.cb_is_created.SelectedIndexChanged += new System.EventHandler(this.changed);
            // 
            // tb_memo
            // 
            this.tb_memo.Location = new System.Drawing.Point(184, 385);
            this.tb_memo.Multiline = true;
            this.tb_memo.Name = "tb_memo";
            this.tb_memo.Size = new System.Drawing.Size(414, 68);
            this.tb_memo.TabIndex = 11;
            this.tb_memo.TextChanged += new System.EventHandler(this.changed);
            // 
            // tb_sim
            // 
            this.tb_sim.Location = new System.Drawing.Point(184, 44);
            this.tb_sim.Name = "tb_sim";
            this.tb_sim.Size = new System.Drawing.Size(414, 23);
            this.tb_sim.TabIndex = 2;
            this.tb_sim.TextChanged += new System.EventHandler(this.changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "APN名称";
            // 
            // tb_iggsn
            // 
            this.tb_iggsn.Location = new System.Drawing.Point(184, 348);
            this.tb_iggsn.Name = "tb_iggsn";
            this.tb_iggsn.Size = new System.Drawing.Size(414, 23);
            this.tb_iggsn.TabIndex = 10;
            this.tb_iggsn.TextChanged += new System.EventHandler(this.changed);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIM卡分配地址";
            // 
            // tb_to_server
            // 
            this.tb_to_server.Location = new System.Drawing.Point(184, 310);
            this.tb_to_server.Name = "tb_to_server";
            this.tb_to_server.Size = new System.Drawing.Size(414, 23);
            this.tb_to_server.TabIndex = 9;
            this.tb_to_server.TextChanged += new System.EventHandler(this.changed);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "静态/动态";
            // 
            // tb_to_pri
            // 
            this.tb_to_pri.Location = new System.Drawing.Point(184, 273);
            this.tb_to_pri.Name = "tb_to_pri";
            this.tb_to_pri.Size = new System.Drawing.Size(414, 23);
            this.tb_to_pri.TabIndex = 8;
            this.tb_to_pri.TextChanged += new System.EventHandler(this.changed);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "是否创建GRE隧道";
            // 
            // tb_pri
            // 
            this.tb_pri.Location = new System.Drawing.Point(184, 236);
            this.tb_pri.Name = "tb_pri";
            this.tb_pri.Size = new System.Drawing.Size(414, 23);
            this.tb_pri.TabIndex = 7;
            this.tb_pri.TextChanged += new System.EventHandler(this.changed);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "本端GRE隧道公网地址";
            // 
            // tb_to_pub
            // 
            this.tb_to_pub.Location = new System.Drawing.Point(184, 198);
            this.tb_to_pub.Name = "tb_to_pub";
            this.tb_to_pub.Size = new System.Drawing.Size(414, 23);
            this.tb_to_pub.TabIndex = 6;
            this.tb_to_pub.TextChanged += new System.EventHandler(this.changed);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "对端GRE隧道公网地址";
            // 
            // tb_pub
            // 
            this.tb_pub.Location = new System.Drawing.Point(184, 161);
            this.tb_pub.Name = "tb_pub";
            this.tb_pub.Size = new System.Drawing.Size(414, 23);
            this.tb_pub.TabIndex = 5;
            this.tb_pub.TextChanged += new System.EventHandler(this.changed);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "本端GRE隧道私网地址";
            // 
            // tb_apn
            // 
            this.tb_apn.Location = new System.Drawing.Point(184, 7);
            this.tb_apn.Name = "tb_apn";
            this.tb_apn.Size = new System.Drawing.Size(414, 23);
            this.tb_apn.TabIndex = 1;
            this.tb_apn.TextChanged += new System.EventHandler(this.changed);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "对端GRE隧道私网地址";
            // 
            // cb_is_static
            // 
            this.cb_is_static.FormattingEnabled = true;
            this.cb_is_static.Items.AddRange(new object[] {
            "静态",
            "动态"});
            this.cb_is_static.Location = new System.Drawing.Point(184, 82);
            this.cb_is_static.Name = "cb_is_static";
            this.cb_is_static.Size = new System.Drawing.Size(414, 22);
            this.cb_is_static.TabIndex = 3;
            this.cb_is_static.SelectedIndexChanged += new System.EventHandler(this.changed);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 388);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 14);
            this.label11.TabIndex = 1;
            this.label11.Text = "备注";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 351);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "所属IGGSN";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "对端服务器IP地址";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_run);
            this.tabPage4.Controls.Add(this.splitContainer2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(606, 471);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "设备管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(511, 436);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(87, 27);
            this.btn_run.TabIndex = 16;
            this.btn_run.Text = "去运行脚本";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(7, 78);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.tb_template);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.tb_script);
            this.splitContainer2.Size = new System.Drawing.Size(591, 352);
            this.splitContainer2.SplitterDistance = 288;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 14);
            this.label13.TabIndex = 1;
            this.label13.Text = "模板";
            // 
            // tb_template
            // 
            this.tb_template.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_template.Location = new System.Drawing.Point(0, 17);
            this.tb_template.Multiline = true;
            this.tb_template.Name = "tb_template";
            this.tb_template.ReadOnly = true;
            this.tb_template.Size = new System.Drawing.Size(288, 335);
            this.tb_template.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 14);
            this.label14.TabIndex = 1;
            this.label14.Text = "生成脚本";
            // 
            // tb_script
            // 
            this.tb_script.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_script.Location = new System.Drawing.Point(0, 17);
            this.tb_script.Multiline = true;
            this.tb_script.Name = "tb_script";
            this.tb_script.ReadOnly = true;
            this.tb_script.Size = new System.Drawing.Size(298, 335);
            this.tb_script.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lb_device_model);
            this.groupBox1.Controls.Add(this.cb_device_brand);
            this.groupBox1.Controls.Add(this.cb_device_model);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择设备";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 1;
            this.label12.Text = "品牌";
            // 
            // lb_device_model
            // 
            this.lb_device_model.AutoSize = true;
            this.lb_device_model.Location = new System.Drawing.Point(215, 31);
            this.lb_device_model.Name = "lb_device_model";
            this.lb_device_model.Size = new System.Drawing.Size(35, 14);
            this.lb_device_model.TabIndex = 1;
            this.lb_device_model.Text = "型号";
            // 
            // cb_device_brand
            // 
            this.cb_device_brand.FormattingEnabled = true;
            this.cb_device_brand.Location = new System.Drawing.Point(66, 28);
            this.cb_device_brand.Name = "cb_device_brand";
            this.cb_device_brand.Size = new System.Drawing.Size(140, 22);
            this.cb_device_brand.TabIndex = 14;
            this.cb_device_brand.SelectedIndexChanged += new System.EventHandler(this.cb_device_brand_SelectedIndexChanged);
            // 
            // cb_device_model
            // 
            this.cb_device_model.FormattingEnabled = true;
            this.cb_device_model.Location = new System.Drawing.Point(255, 28);
            this.cb_device_model.Name = "cb_device_model";
            this.cb_device_model.Size = new System.Drawing.Size(140, 22);
            this.cb_device_model.TabIndex = 15;
            this.cb_device_model.SelectedIndexChanged += new System.EventHandler(this.cb_device_model_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Controls.Add(this.tb_run);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(606, 469);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "运行脚本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 469);
            this.tabControl1.TabIndex = 999;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_password_telnet);
            this.tabPage2.Controls.Add(this.tb_username_telnet);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.btn_run_telnet);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tb_result);
            this.tabPage2.Controls.Add(this.tb_port_telnet);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tb_ip_telnet);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 441);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Telnet连接";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_password_telnet
            // 
            this.tb_password_telnet.Location = new System.Drawing.Point(289, 35);
            this.tb_password_telnet.Name = "tb_password_telnet";
            this.tb_password_telnet.Size = new System.Drawing.Size(148, 23);
            this.tb_password_telnet.TabIndex = 10;
            this.tb_password_telnet.Text = "zx880918";
            // 
            // tb_username_telnet
            // 
            this.tb_username_telnet.Location = new System.Drawing.Point(75, 35);
            this.tb_username_telnet.Name = "tb_username_telnet";
            this.tb_username_telnet.Size = new System.Drawing.Size(153, 23);
            this.tb_username_telnet.TabIndex = 9;
            this.tb_username_telnet.Text = "xin";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(234, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 14);
            this.label19.TabIndex = 8;
            this.label19.Text = "密码：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 14);
            this.label18.TabIndex = 7;
            this.label18.Text = "用户名：";
            // 
            // btn_run_telnet
            // 
            this.btn_run_telnet.Location = new System.Drawing.Point(455, 34);
            this.btn_run_telnet.Name = "btn_run_telnet";
            this.btn_run_telnet.Size = new System.Drawing.Size(75, 23);
            this.btn_run_telnet.TabIndex = 6;
            this.btn_run_telnet.Text = "开始运行";
            this.btn_run_telnet.UseVisualStyleBackColor = true;
            this.btn_run_telnet.Click += new System.EventHandler(this.btn_run_telnet_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 14);
            this.label17.TabIndex = 5;
            this.label17.Text = "运行结果：";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(7, 87);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(585, 348);
            this.tb_result.TabIndex = 4;
            // 
            // tb_port_telnet
            // 
            this.tb_port_telnet.Location = new System.Drawing.Point(386, 6);
            this.tb_port_telnet.Name = "tb_port_telnet";
            this.tb_port_telnet.Size = new System.Drawing.Size(51, 23);
            this.tb_port_telnet.TabIndex = 3;
            this.tb_port_telnet.Text = "23";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(331, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "端口：";
            // 
            // tb_ip_telnet
            // 
            this.tb_ip_telnet.Location = new System.Drawing.Point(75, 6);
            this.tb_ip_telnet.Name = "tb_ip_telnet";
            this.tb_ip_telnet.Size = new System.Drawing.Size(250, 23);
            this.tb_ip_telnet.TabIndex = 1;
            this.tb_ip_telnet.Text = "127.0.0.1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "IP地址：";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.tb_rate_com);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.cb_port_com);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(598, 443);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "COM连接";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "开始运行";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 14);
            this.label22.TabIndex = 7;
            this.label22.Text = "运行结果:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 376);
            this.textBox1.TabIndex = 6;
            // 
            // tb_rate_com
            // 
            this.tb_rate_com.Location = new System.Drawing.Point(257, 6);
            this.tb_rate_com.Name = "tb_rate_com";
            this.tb_rate_com.Size = new System.Drawing.Size(100, 23);
            this.tb_rate_com.TabIndex = 5;
            this.tb_rate_com.Text = "9600";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(188, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 14);
            this.label21.TabIndex = 4;
            this.label21.Text = "波特率：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 14);
            this.label20.TabIndex = 3;
            this.label20.Text = "串口：";
            // 
            // cb_port_com
            // 
            this.cb_port_com.FormattingEnabled = true;
            this.cb_port_com.Location = new System.Drawing.Point(61, 6);
            this.cb_port_com.Name = "cb_port_com";
            this.cb_port_com.Size = new System.Drawing.Size(121, 22);
            this.cb_port_com.TabIndex = 0;
            // 
            // tb_run
            // 
            this.tb_run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_run.Location = new System.Drawing.Point(0, 0);
            this.tb_run.Multiline = true;
            this.tb_run.Name = "tb_run";
            this.tb_run.ReadOnly = true;
            this.tb_run.Size = new System.Drawing.Size(606, 469);
            this.tb_run.TabIndex = 998;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(804, 604);
            this.MinimumSize = new System.Drawing.Size(804, 604);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APN容灾系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUser_FormClosed);
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tab_apn.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_apn_filter;
        private System.Windows.Forms.ListBox list_apn;
        private System.Windows.Forms.TabControl tab_apn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cb_is_created;
        private System.Windows.Forms.TextBox tb_memo;
        private System.Windows.Forms.TextBox tb_sim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_iggsn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_to_server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_to_pri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_to_pub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_apn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_is_static;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_apn_cancel;
        private System.Windows.Forms.Button btn_apn_save;
        private System.Windows.Forms.Label lb_device_model;
        private System.Windows.Forms.ComboBox cb_device_model;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_device_brand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tb_template;
        private System.Windows.Forms.TextBox tb_script;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_run;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_run_telnet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.TextBox tb_port_telnet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_ip_telnet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tb_password_telnet;
        private System.Windows.Forms.TextBox tb_username_telnet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_port_com;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tb_rate_com;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
    }
}