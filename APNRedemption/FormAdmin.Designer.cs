namespace APNRedemption
{
    partial class FormAdmin
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
            this.tb_apn_filter = new System.Windows.Forms.TextBox();
            this.list_apn = new System.Windows.Forms.ListBox();
            this.apnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arAPN = new APNRedemption.arAPN();
            this.m_apn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_apn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_add_apn = new System.Windows.Forms.Button();
            this.apnTableAdapter = new APNRedemption.arAPNTableAdapters.ApnTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tab_apn = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lb_apn_vpn_source = new System.Windows.Forms.Label();
            this.lb_apn_vpn_destination = new System.Windows.Forms.Label();
            this.lb_apn_vpn_ipaddress = new System.Windows.Forms.Label();
            this.lb_apn_vpn_route = new System.Windows.Forms.Label();
            this.lb_apn_vpn_route1 = new System.Windows.Forms.Label();
            this.lb_apn_vpn_ipaddress1 = new System.Windows.Forms.Label();
            this.lb_apn_vpn_destination1 = new System.Windows.Forms.Label();
            this.lb_apn_vpn_source1 = new System.Windows.Forms.Label();
            this.tb_apn_serverip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_apn_dns = new System.Windows.Forms.Button();
            this.btn_apn_preview = new System.Windows.Forms.Button();
            this.btn_apn_cancel = new System.Windows.Forms.Button();
            this.tb_apn_memo = new System.Windows.Forms.TextBox();
            this.btn_apn_save = new System.Windows.Forms.Button();
            this.tb_apn_contact = new System.Windows.Forms.TextBox();
            this.tb_apn_tunnel_name = new System.Windows.Forms.TextBox();
            this.tb_apn_ggsn_gnif = new System.Windows.Forms.TextBox();
            this.tb_apn_ggsn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_apn_vpn1_id = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_apn_sim_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_apn_apn_name = new System.Windows.Forms.TextBox();
            this.cb_apn_is_static = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.clb_apn_user = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VPNAdmin = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_f_vpn = new System.Windows.Forms.TextBox();
            this.lb_vpn = new System.Windows.Forms.ListBox();
            this.btn_add_vpn = new System.Windows.Forms.Button();
            this.tc_vpn = new System.Windows.Forms.TabControl();
            this.tp_vpn_set = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_vpn_source1 = new System.Windows.Forms.TextBox();
            this.tb_vpn_destination1 = new System.Windows.Forms.TextBox();
            this.tb_vpn_ipaddress1 = new System.Windows.Forms.TextBox();
            this.tb_vpn_route1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_vpn_source = new System.Windows.Forms.TextBox();
            this.tb_vpn_destination = new System.Windows.Forms.TextBox();
            this.tb_vpn_ipaddress = new System.Windows.Forms.TextBox();
            this.tb_vpn_route = new System.Windows.Forms.TextBox();
            this.tb_vpn_memo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.l_vpn_script = new System.Windows.Forms.Label();
            this.btn_vpn_preview = new System.Windows.Forms.Button();
            this.btn_vpn_cancel = new System.Windows.Forms.Button();
            this.btn_vpn_save = new System.Windows.Forms.Button();
            this.tb_vpn_vpn_name = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tp_vpn_apn = new System.Windows.Forms.TabPage();
            this.APNAdmin = new System.Windows.Forms.TabPage();
            this.UserAdmin = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_user_filter = new System.Windows.Forms.TextBox();
            this.list_user = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arAPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add_user = new System.Windows.Forms.Button();
            this.tab_user = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.user_apn = new System.Windows.Forms.CheckedListBox();
            this.btn_user_cancel = new System.Windows.Forms.Button();
            this.btn_user_save = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_script_run = new System.Windows.Forms.Button();
            this.btn_script_gen = new System.Windows.Forms.Button();
            this.tb_script = new System.Windows.Forms.TextBox();
            this.userTableAdapter = new APNRedemption.arAPNTableAdapters.UserTableAdapter();
            this.btn_script_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arAPN)).BeginInit();
            this.m_apn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_apn.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.VPNAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tc_vpn.SuspendLayout();
            this.tp_vpn_set.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.APNAdmin.SuspendLayout();
            this.UserAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arAPNBindingSource)).BeginInit();
            this.tab_user.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_apn_filter
            // 
            this.tb_apn_filter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_apn_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_apn_filter.Location = new System.Drawing.Point(4, 4);
            this.tb_apn_filter.Name = "tb_apn_filter";
            this.tb_apn_filter.Size = new System.Drawing.Size(157, 19);
            this.tb_apn_filter.TabIndex = 0;
            this.tb_apn_filter.Text = "过滤";
            this.tb_apn_filter.Enter += new System.EventHandler(this.enter_filter);
            this.tb_apn_filter.Leave += new System.EventHandler(this.leave_filter);
            // 
            // list_apn
            // 
            this.list_apn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_apn.DataSource = this.apnBindingSource;
            this.list_apn.DisplayMember = "apn";
            this.list_apn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_apn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_apn.FormattingEnabled = true;
            this.list_apn.ItemHeight = 14;
            this.list_apn.Location = new System.Drawing.Point(4, 30);
            this.list_apn.Name = "list_apn";
            this.list_apn.Size = new System.Drawing.Size(157, 447);
            this.list_apn.TabIndex = 1;
            this.list_apn.ValueMember = "ID";
            this.list_apn.SelectedIndexChanged += new System.EventHandler(this.list_apn_SelectedIndexChanged);
            this.list_apn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.list_apn_MouseUp);
            // 
            // apnBindingSource
            // 
            this.apnBindingSource.DataMember = "Apn";
            this.apnBindingSource.DataSource = this.arAPN;
            // 
            // arAPN
            // 
            this.arAPN.DataSetName = "arAPN";
            this.arAPN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_apn
            // 
            this.m_apn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_apn_delete});
            this.m_apn.Name = "contextMenuStrip1";
            this.m_apn.Size = new System.Drawing.Size(99, 26);
            // 
            // btn_apn_delete
            // 
            this.btn_apn_delete.Name = "btn_apn_delete";
            this.btn_apn_delete.Size = new System.Drawing.Size(98, 22);
            this.btn_apn_delete.Text = "删除";
            this.btn_apn_delete.Click += new System.EventHandler(this.btn_apn_delete_Click);
            // 
            // btn_add_apn
            // 
            this.btn_add_apn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_apn.Location = new System.Drawing.Point(4, 484);
            this.btn_add_apn.Name = "btn_add_apn";
            this.btn_add_apn.Size = new System.Drawing.Size(157, 34);
            this.btn_add_apn.TabIndex = 2;
            this.btn_add_apn.Text = "添加APN";
            this.btn_add_apn.UseVisualStyleBackColor = true;
            this.btn_add_apn.Click += new System.EventHandler(this.btn_add_apn_Click);
            // 
            // apnTableAdapter
            // 
            this.apnTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tab_apn);
            this.splitContainer1.Size = new System.Drawing.Size(770, 523);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_apn_filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.list_apn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_apn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 522);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tab_apn
            // 
            this.tab_apn.Controls.Add(this.tabPage3);
            this.tab_apn.Controls.Add(this.tabPage4);
            this.tab_apn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_apn.Location = new System.Drawing.Point(0, 0);
            this.tab_apn.Name = "tab_apn";
            this.tab_apn.SelectedIndex = 0;
            this.tab_apn.Size = new System.Drawing.Size(601, 523);
            this.tab_apn.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Controls.Add(this.tb_apn_serverip);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btn_apn_dns);
            this.tabPage3.Controls.Add(this.btn_apn_preview);
            this.tabPage3.Controls.Add(this.btn_apn_cancel);
            this.tabPage3.Controls.Add(this.tb_apn_memo);
            this.tabPage3.Controls.Add(this.btn_apn_save);
            this.tabPage3.Controls.Add(this.tb_apn_contact);
            this.tabPage3.Controls.Add(this.tb_apn_tunnel_name);
            this.tabPage3.Controls.Add(this.tb_apn_ggsn_gnif);
            this.tabPage3.Controls.Add(this.tb_apn_ggsn);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cb_apn_vpn1_id);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tb_apn_sim_ip);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tb_apn_apn_name);
            this.tabPage3.Controls.Add(this.cb_apn_is_static);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(593, 490);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.label24, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label23, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_source, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_destination, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_ipaddress, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_route, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_route1, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_ipaddress1, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_destination1, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_apn_vpn_source1, 2, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 170);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(581, 114);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(97, 91);
            this.label24.Margin = new System.Windows.Forms.Padding(3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "本端公网地址";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(97, 69);
            this.label22.Margin = new System.Windows.Forms.Padding(3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 16);
            this.label22.TabIndex = 6;
            this.label22.Text = "本端私网地址";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(97, 47);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 16);
            this.label20.TabIndex = 5;
            this.label20.Text = "对端公网地址";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "本端公网地址";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(338, 3);
            this.label23.Margin = new System.Windows.Forms.Padding(3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 16);
            this.label23.TabIndex = 7;
            this.label23.Text = "隧道1";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(533, 3);
            this.label25.Margin = new System.Windows.Forms.Padding(3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 16);
            this.label25.TabIndex = 7;
            this.label25.Text = "隧道2";
            // 
            // lb_apn_vpn_source
            // 
            this.lb_apn_vpn_source.AutoSize = true;
            this.lb_apn_vpn_source.Location = new System.Drawing.Point(196, 22);
            this.lb_apn_vpn_source.Name = "lb_apn_vpn_source";
            this.lb_apn_vpn_source.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_source.TabIndex = 9;
            this.lb_apn_vpn_source.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_destination
            // 
            this.lb_apn_vpn_destination.AutoSize = true;
            this.lb_apn_vpn_destination.Location = new System.Drawing.Point(196, 44);
            this.lb_apn_vpn_destination.Name = "lb_apn_vpn_destination";
            this.lb_apn_vpn_destination.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_destination.TabIndex = 10;
            this.lb_apn_vpn_destination.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_ipaddress
            // 
            this.lb_apn_vpn_ipaddress.AutoSize = true;
            this.lb_apn_vpn_ipaddress.Location = new System.Drawing.Point(196, 66);
            this.lb_apn_vpn_ipaddress.Name = "lb_apn_vpn_ipaddress";
            this.lb_apn_vpn_ipaddress.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_ipaddress.TabIndex = 10;
            this.lb_apn_vpn_ipaddress.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_route
            // 
            this.lb_apn_vpn_route.AutoSize = true;
            this.lb_apn_vpn_route.Location = new System.Drawing.Point(196, 88);
            this.lb_apn_vpn_route.Name = "lb_apn_vpn_route";
            this.lb_apn_vpn_route.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_route.TabIndex = 10;
            this.lb_apn_vpn_route.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_route1
            // 
            this.lb_apn_vpn_route1.AutoSize = true;
            this.lb_apn_vpn_route1.Location = new System.Drawing.Point(389, 88);
            this.lb_apn_vpn_route1.Name = "lb_apn_vpn_route1";
            this.lb_apn_vpn_route1.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_route1.TabIndex = 10;
            this.lb_apn_vpn_route1.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_ipaddress1
            // 
            this.lb_apn_vpn_ipaddress1.AutoSize = true;
            this.lb_apn_vpn_ipaddress1.Location = new System.Drawing.Point(389, 66);
            this.lb_apn_vpn_ipaddress1.Name = "lb_apn_vpn_ipaddress1";
            this.lb_apn_vpn_ipaddress1.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_ipaddress1.TabIndex = 10;
            this.lb_apn_vpn_ipaddress1.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_destination1
            // 
            this.lb_apn_vpn_destination1.AutoSize = true;
            this.lb_apn_vpn_destination1.Location = new System.Drawing.Point(389, 44);
            this.lb_apn_vpn_destination1.Name = "lb_apn_vpn_destination1";
            this.lb_apn_vpn_destination1.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_destination1.TabIndex = 10;
            this.lb_apn_vpn_destination1.Text = "请选择VPN隧道";
            // 
            // lb_apn_vpn_source1
            // 
            this.lb_apn_vpn_source1.AutoSize = true;
            this.lb_apn_vpn_source1.Location = new System.Drawing.Point(389, 22);
            this.lb_apn_vpn_source1.Name = "lb_apn_vpn_source1";
            this.lb_apn_vpn_source1.Size = new System.Drawing.Size(108, 20);
            this.lb_apn_vpn_source1.TabIndex = 10;
            this.lb_apn_vpn_source1.Text = "请选择VPN隧道";
            // 
            // tb_apn_serverip
            // 
            this.tb_apn_serverip.Location = new System.Drawing.Point(121, 104);
            this.tb_apn_serverip.Name = "tb_apn_serverip";
            this.tb_apn_serverip.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_serverip.TabIndex = 21;
            this.tb_apn_serverip.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "服务器地址";
            // 
            // btn_apn_dns
            // 
            this.btn_apn_dns.Location = new System.Drawing.Point(242, 450);
            this.btn_apn_dns.Name = "btn_apn_dns";
            this.btn_apn_dns.Size = new System.Drawing.Size(115, 34);
            this.btn_apn_dns.TabIndex = 19;
            this.btn_apn_dns.Text = "脚本（DNS）";
            this.btn_apn_dns.UseVisualStyleBackColor = true;
            this.btn_apn_dns.Click += new System.EventHandler(this.btn_apn_dns_Click);
            // 
            // btn_apn_preview
            // 
            this.btn_apn_preview.Location = new System.Drawing.Point(121, 450);
            this.btn_apn_preview.Name = "btn_apn_preview";
            this.btn_apn_preview.Size = new System.Drawing.Size(115, 34);
            this.btn_apn_preview.TabIndex = 18;
            this.btn_apn_preview.Text = "脚本（新建）";
            this.btn_apn_preview.UseVisualStyleBackColor = true;
            this.btn_apn_preview.Click += new System.EventHandler(this.btn_apn_preview_Click);
            // 
            // btn_apn_cancel
            // 
            this.btn_apn_cancel.Location = new System.Drawing.Point(482, 450);
            this.btn_apn_cancel.Name = "btn_apn_cancel";
            this.btn_apn_cancel.Size = new System.Drawing.Size(106, 34);
            this.btn_apn_cancel.TabIndex = 6;
            this.btn_apn_cancel.Text = "取消";
            this.btn_apn_cancel.UseVisualStyleBackColor = true;
            // 
            // tb_apn_memo
            // 
            this.tb_apn_memo.Location = new System.Drawing.Point(121, 418);
            this.tb_apn_memo.Name = "tb_apn_memo";
            this.tb_apn_memo.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_memo.TabIndex = 17;
            this.tb_apn_memo.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // btn_apn_save
            // 
            this.btn_apn_save.Location = new System.Drawing.Point(370, 450);
            this.btn_apn_save.Name = "btn_apn_save";
            this.btn_apn_save.Size = new System.Drawing.Size(106, 34);
            this.btn_apn_save.TabIndex = 5;
            this.btn_apn_save.Text = "保存";
            this.btn_apn_save.UseVisualStyleBackColor = true;
            this.btn_apn_save.Click += new System.EventHandler(this.btn_apn_save_Click);
            // 
            // tb_apn_contact
            // 
            this.tb_apn_contact.Location = new System.Drawing.Point(121, 386);
            this.tb_apn_contact.Name = "tb_apn_contact";
            this.tb_apn_contact.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_contact.TabIndex = 16;
            this.tb_apn_contact.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // tb_apn_tunnel_name
            // 
            this.tb_apn_tunnel_name.Location = new System.Drawing.Point(121, 290);
            this.tb_apn_tunnel_name.Name = "tb_apn_tunnel_name";
            this.tb_apn_tunnel_name.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_tunnel_name.TabIndex = 15;
            this.tb_apn_tunnel_name.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // tb_apn_ggsn_gnif
            // 
            this.tb_apn_ggsn_gnif.Location = new System.Drawing.Point(121, 354);
            this.tb_apn_ggsn_gnif.Name = "tb_apn_ggsn_gnif";
            this.tb_apn_ggsn_gnif.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_ggsn_gnif.TabIndex = 14;
            this.tb_apn_ggsn_gnif.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // tb_apn_ggsn
            // 
            this.tb_apn_ggsn.Location = new System.Drawing.Point(121, 322);
            this.tb_apn_ggsn.Name = "tb_apn_ggsn";
            this.tb_apn_ggsn.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_ggsn.TabIndex = 13;
            this.tb_apn_ggsn.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "联系人";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "GNIF地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "隧道接口名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "所属GGSN";
            // 
            // cb_apn_vpn1_id
            // 
            this.cb_apn_vpn1_id.FormattingEnabled = true;
            this.cb_apn_vpn1_id.Location = new System.Drawing.Point(121, 136);
            this.cb_apn_vpn1_id.Name = "cb_apn_vpn1_id";
            this.cb_apn_vpn1_id.Size = new System.Drawing.Size(466, 28);
            this.cb_apn_vpn1_id.TabIndex = 6;
            this.cb_apn_vpn1_id.SelectedIndexChanged += new System.EventHandler(this.cb_apn_vpn1_id_SelectedIndexChanged);
            this.cb_apn_vpn1_id.SelectedValueChanged += new System.EventHandler(this.apn_changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "VPN隧道";
            // 
            // tb_apn_sim_ip
            // 
            this.tb_apn_sim_ip.Location = new System.Drawing.Point(121, 38);
            this.tb_apn_sim_ip.Name = "tb_apn_sim_ip";
            this.tb_apn_sim_ip.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_sim_ip.TabIndex = 2;
            this.tb_apn_sim_ip.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "APN名称";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIM地址";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "静态/动态";
            // 
            // tb_apn_apn_name
            // 
            this.tb_apn_apn_name.Location = new System.Drawing.Point(121, 6);
            this.tb_apn_apn_name.Name = "tb_apn_apn_name";
            this.tb_apn_apn_name.Size = new System.Drawing.Size(466, 26);
            this.tb_apn_apn_name.TabIndex = 2;
            this.tb_apn_apn_name.TextChanged += new System.EventHandler(this.apn_changed);
            // 
            // cb_apn_is_static
            // 
            this.cb_apn_is_static.FormattingEnabled = true;
            this.cb_apn_is_static.Location = new System.Drawing.Point(121, 70);
            this.cb_apn_is_static.Name = "cb_apn_is_static";
            this.cb_apn_is_static.Size = new System.Drawing.Size(466, 28);
            this.cb_apn_is_static.TabIndex = 3;
            this.cb_apn_is_static.SelectedValueChanged += new System.EventHandler(this.apn_changed);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.clb_apn_user);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(593, 490);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "管理员";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // clb_apn_user
            // 
            this.clb_apn_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_apn_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clb_apn_user.FormattingEnabled = true;
            this.clb_apn_user.Location = new System.Drawing.Point(3, 3);
            this.clb_apn_user.MultiColumn = true;
            this.clb_apn_user.Name = "clb_apn_user";
            this.clb_apn_user.Size = new System.Drawing.Size(587, 484);
            this.clb_apn_user.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VPNAdmin);
            this.tabControl1.Controls.Add(this.APNAdmin);
            this.tabControl1.Controls.Add(this.UserAdmin);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 561);
            this.tabControl1.TabIndex = 4;
            // 
            // VPNAdmin
            // 
            this.VPNAdmin.Controls.Add(this.splitContainer3);
            this.VPNAdmin.Location = new System.Drawing.Point(4, 29);
            this.VPNAdmin.Name = "VPNAdmin";
            this.VPNAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.VPNAdmin.Size = new System.Drawing.Size(776, 528);
            this.VPNAdmin.TabIndex = 2;
            this.VPNAdmin.Text = "VPN管理";
            this.VPNAdmin.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tc_vpn);
            this.splitContainer3.Size = new System.Drawing.Size(770, 522);
            this.splitContainer3.SplitterDistance = 163;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tb_f_vpn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_vpn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_add_vpn, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 522);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tb_f_vpn
            // 
            this.tb_f_vpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_f_vpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_f_vpn.Location = new System.Drawing.Point(4, 4);
            this.tb_f_vpn.Name = "tb_f_vpn";
            this.tb_f_vpn.Size = new System.Drawing.Size(155, 19);
            this.tb_f_vpn.TabIndex = 0;
            this.tb_f_vpn.Text = "过滤";
            // 
            // lb_vpn
            // 
            this.lb_vpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_vpn.DataSource = this.apnBindingSource;
            this.lb_vpn.DisplayMember = "apn";
            this.lb_vpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_vpn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_vpn.FormattingEnabled = true;
            this.lb_vpn.ItemHeight = 14;
            this.lb_vpn.Location = new System.Drawing.Point(4, 30);
            this.lb_vpn.Name = "lb_vpn";
            this.lb_vpn.Size = new System.Drawing.Size(155, 447);
            this.lb_vpn.TabIndex = 1;
            this.lb_vpn.ValueMember = "ID";
            this.lb_vpn.SelectedIndexChanged += new System.EventHandler(this.lb_vpn_SelectedIndexChanged);
            // 
            // btn_add_vpn
            // 
            this.btn_add_vpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_vpn.Location = new System.Drawing.Point(4, 484);
            this.btn_add_vpn.Name = "btn_add_vpn";
            this.btn_add_vpn.Size = new System.Drawing.Size(155, 34);
            this.btn_add_vpn.TabIndex = 2;
            this.btn_add_vpn.Text = "添加VPN";
            this.btn_add_vpn.UseVisualStyleBackColor = true;
            this.btn_add_vpn.Click += new System.EventHandler(this.btn_add_vpn_Click);
            // 
            // tc_vpn
            // 
            this.tc_vpn.Controls.Add(this.tp_vpn_set);
            this.tc_vpn.Controls.Add(this.tp_vpn_apn);
            this.tc_vpn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_vpn.Location = new System.Drawing.Point(0, 0);
            this.tc_vpn.Name = "tc_vpn";
            this.tc_vpn.SelectedIndex = 0;
            this.tc_vpn.Size = new System.Drawing.Size(603, 522);
            this.tc_vpn.TabIndex = 0;
            // 
            // tp_vpn_set
            // 
            this.tp_vpn_set.Controls.Add(this.groupBox2);
            this.tp_vpn_set.Controls.Add(this.groupBox1);
            this.tp_vpn_set.Controls.Add(this.tb_vpn_memo);
            this.tp_vpn_set.Controls.Add(this.label21);
            this.tp_vpn_set.Controls.Add(this.l_vpn_script);
            this.tp_vpn_set.Controls.Add(this.btn_vpn_preview);
            this.tp_vpn_set.Controls.Add(this.btn_vpn_cancel);
            this.tp_vpn_set.Controls.Add(this.btn_vpn_save);
            this.tp_vpn_set.Controls.Add(this.tb_vpn_vpn_name);
            this.tp_vpn_set.Controls.Add(this.label19);
            this.tp_vpn_set.Controls.Add(this.label15);
            this.tp_vpn_set.Controls.Add(this.label16);
            this.tp_vpn_set.Controls.Add(this.label17);
            this.tp_vpn_set.Controls.Add(this.label18);
            this.tp_vpn_set.Location = new System.Drawing.Point(4, 29);
            this.tp_vpn_set.Name = "tp_vpn_set";
            this.tp_vpn_set.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vpn_set.Size = new System.Drawing.Size(595, 489);
            this.tp_vpn_set.TabIndex = 0;
            this.tp_vpn_set.Text = "设置";
            this.tp_vpn_set.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_vpn_source1);
            this.groupBox2.Controls.Add(this.tb_vpn_destination1);
            this.groupBox2.Controls.Add(this.tb_vpn_ipaddress1);
            this.groupBox2.Controls.Add(this.tb_vpn_route1);
            this.groupBox2.Location = new System.Drawing.Point(375, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 158);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "隧道2（可以为空）";
            // 
            // tb_vpn_source1
            // 
            this.tb_vpn_source1.Location = new System.Drawing.Point(6, 25);
            this.tb_vpn_source1.Name = "tb_vpn_source1";
            this.tb_vpn_source1.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_source1.TabIndex = 10;
            this.tb_vpn_source1.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_destination1
            // 
            this.tb_vpn_destination1.Location = new System.Drawing.Point(6, 59);
            this.tb_vpn_destination1.Name = "tb_vpn_destination1";
            this.tb_vpn_destination1.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_destination1.TabIndex = 9;
            this.tb_vpn_destination1.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_ipaddress1
            // 
            this.tb_vpn_ipaddress1.Location = new System.Drawing.Point(6, 91);
            this.tb_vpn_ipaddress1.Name = "tb_vpn_ipaddress1";
            this.tb_vpn_ipaddress1.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_ipaddress1.TabIndex = 8;
            this.tb_vpn_ipaddress1.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_route1
            // 
            this.tb_vpn_route1.Location = new System.Drawing.Point(6, 123);
            this.tb_vpn_route1.Name = "tb_vpn_route1";
            this.tb_vpn_route1.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_route1.TabIndex = 7;
            this.tb_vpn_route1.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_vpn_source);
            this.groupBox1.Controls.Add(this.tb_vpn_destination);
            this.groupBox1.Controls.Add(this.tb_vpn_ipaddress);
            this.groupBox1.Controls.Add(this.tb_vpn_route);
            this.groupBox1.Location = new System.Drawing.Point(105, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 158);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "隧道1";
            // 
            // tb_vpn_source
            // 
            this.tb_vpn_source.Location = new System.Drawing.Point(6, 25);
            this.tb_vpn_source.Name = "tb_vpn_source";
            this.tb_vpn_source.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_source.TabIndex = 10;
            this.tb_vpn_source.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_destination
            // 
            this.tb_vpn_destination.Location = new System.Drawing.Point(6, 59);
            this.tb_vpn_destination.Name = "tb_vpn_destination";
            this.tb_vpn_destination.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_destination.TabIndex = 9;
            this.tb_vpn_destination.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_ipaddress
            // 
            this.tb_vpn_ipaddress.Location = new System.Drawing.Point(6, 91);
            this.tb_vpn_ipaddress.Name = "tb_vpn_ipaddress";
            this.tb_vpn_ipaddress.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_ipaddress.TabIndex = 8;
            this.tb_vpn_ipaddress.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_route
            // 
            this.tb_vpn_route.Location = new System.Drawing.Point(6, 123);
            this.tb_vpn_route.Name = "tb_vpn_route";
            this.tb_vpn_route.Size = new System.Drawing.Size(200, 26);
            this.tb_vpn_route.TabIndex = 7;
            this.tb_vpn_route.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // tb_vpn_memo
            // 
            this.tb_vpn_memo.Location = new System.Drawing.Point(105, 212);
            this.tb_vpn_memo.Name = "tb_vpn_memo";
            this.tb_vpn_memo.Size = new System.Drawing.Size(484, 26);
            this.tb_vpn_memo.TabIndex = 18;
            this.tb_vpn_memo.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(62, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 20);
            this.label21.TabIndex = 17;
            this.label21.Text = "备注";
            // 
            // l_vpn_script
            // 
            this.l_vpn_script.AutoSize = true;
            this.l_vpn_script.Location = new System.Drawing.Point(101, 247);
            this.l_vpn_script.Name = "l_vpn_script";
            this.l_vpn_script.Size = new System.Drawing.Size(0, 20);
            this.l_vpn_script.TabIndex = 16;
            // 
            // btn_vpn_preview
            // 
            this.btn_vpn_preview.Location = new System.Drawing.Point(104, 244);
            this.btn_vpn_preview.Name = "btn_vpn_preview";
            this.btn_vpn_preview.Size = new System.Drawing.Size(128, 34);
            this.btn_vpn_preview.TabIndex = 15;
            this.btn_vpn_preview.Text = "脚本（新建）";
            this.btn_vpn_preview.UseVisualStyleBackColor = true;
            this.btn_vpn_preview.Click += new System.EventHandler(this.btn_vpn_preview_Click);
            // 
            // btn_vpn_cancel
            // 
            this.btn_vpn_cancel.Location = new System.Drawing.Point(320, 244);
            this.btn_vpn_cancel.Name = "btn_vpn_cancel";
            this.btn_vpn_cancel.Size = new System.Drawing.Size(75, 34);
            this.btn_vpn_cancel.TabIndex = 14;
            this.btn_vpn_cancel.Text = "取消";
            this.btn_vpn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_vpn_save
            // 
            this.btn_vpn_save.Location = new System.Drawing.Point(239, 244);
            this.btn_vpn_save.Name = "btn_vpn_save";
            this.btn_vpn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_vpn_save.TabIndex = 13;
            this.btn_vpn_save.Text = "保存";
            this.btn_vpn_save.UseVisualStyleBackColor = true;
            this.btn_vpn_save.Click += new System.EventHandler(this.btn_vpn_save_Click);
            // 
            // tb_vpn_vpn_name
            // 
            this.tb_vpn_vpn_name.Location = new System.Drawing.Point(105, 6);
            this.tb_vpn_vpn_name.Name = "tb_vpn_vpn_name";
            this.tb_vpn_vpn_name.Size = new System.Drawing.Size(484, 26);
            this.tb_vpn_vpn_name.TabIndex = 12;
            this.tb_vpn_vpn_name.TextChanged += new System.EventHandler(this.vpn_changed);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "VPN名称";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 66);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "本端公网地址";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 100);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "对端公网地址";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 132);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "本端私网地址";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 164);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "对端私网地址";
            // 
            // tp_vpn_apn
            // 
            this.tp_vpn_apn.Location = new System.Drawing.Point(4, 29);
            this.tp_vpn_apn.Name = "tp_vpn_apn";
            this.tp_vpn_apn.Padding = new System.Windows.Forms.Padding(3);
            this.tp_vpn_apn.Size = new System.Drawing.Size(595, 490);
            this.tp_vpn_apn.TabIndex = 1;
            this.tp_vpn_apn.Text = "查看APN";
            this.tp_vpn_apn.UseVisualStyleBackColor = true;
            // 
            // APNAdmin
            // 
            this.APNAdmin.Controls.Add(this.splitContainer1);
            this.APNAdmin.Location = new System.Drawing.Point(4, 29);
            this.APNAdmin.Name = "APNAdmin";
            this.APNAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.APNAdmin.Size = new System.Drawing.Size(776, 529);
            this.APNAdmin.TabIndex = 0;
            this.APNAdmin.Text = "APN管理";
            this.APNAdmin.UseVisualStyleBackColor = true;
            // 
            // UserAdmin
            // 
            this.UserAdmin.Controls.Add(this.splitContainer2);
            this.UserAdmin.Location = new System.Drawing.Point(4, 29);
            this.UserAdmin.Name = "UserAdmin";
            this.UserAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.UserAdmin.Size = new System.Drawing.Size(776, 529);
            this.UserAdmin.TabIndex = 1;
            this.UserAdmin.Text = "用户管理";
            this.UserAdmin.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tab_user);
            this.splitContainer2.Panel2.Controls.Add(this.btn_user_cancel);
            this.splitContainer2.Panel2.Controls.Add(this.btn_user_save);
            this.splitContainer2.Size = new System.Drawing.Size(770, 523);
            this.splitContainer2.SplitterDistance = 165;
            this.splitContainer2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tb_user_filter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.list_user, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_add_user, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(165, 523);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tb_user_filter
            // 
            this.tb_user_filter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_user_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_user_filter.Location = new System.Drawing.Point(4, 4);
            this.tb_user_filter.Name = "tb_user_filter";
            this.tb_user_filter.Size = new System.Drawing.Size(157, 19);
            this.tb_user_filter.TabIndex = 0;
            this.tb_user_filter.Text = "过滤";
            this.tb_user_filter.Enter += new System.EventHandler(this.enter_filter);
            this.tb_user_filter.Leave += new System.EventHandler(this.leave_filter);
            // 
            // list_user
            // 
            this.list_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_user.DataSource = this.userBindingSource;
            this.list_user.DisplayMember = "username";
            this.list_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_user.FormattingEnabled = true;
            this.list_user.ItemHeight = 20;
            this.list_user.Location = new System.Drawing.Point(4, 31);
            this.list_user.Name = "list_user";
            this.list_user.Size = new System.Drawing.Size(157, 447);
            this.list_user.TabIndex = 1;
            this.list_user.ValueMember = "ID";
            this.list_user.SelectedIndexChanged += new System.EventHandler(this.list_user_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.arAPNBindingSource;
            // 
            // arAPNBindingSource
            // 
            this.arAPNBindingSource.DataSource = this.arAPN;
            this.arAPNBindingSource.Position = 0;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_user.Location = new System.Drawing.Point(4, 485);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(157, 34);
            this.btn_add_user.TabIndex = 2;
            this.btn_add_user.Text = "添加用户";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // tab_user
            // 
            this.tab_user.Controls.Add(this.tabPage5);
            this.tab_user.Controls.Add(this.tabPage6);
            this.tab_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_user.Location = new System.Drawing.Point(0, 0);
            this.tab_user.Name = "tab_user";
            this.tab_user.SelectedIndex = 0;
            this.tab_user.Size = new System.Drawing.Size(601, 477);
            this.tab_user.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cb_admin);
            this.tabPage5.Controls.Add(this.tb_username);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.tb_password);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(593, 444);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "设置";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Location = new System.Drawing.Point(105, 67);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(71, 24);
            this.cb_admin.TabIndex = 3;
            this.cb_admin.Text = "admin";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(105, 3);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(482, 26);
            this.tb_username.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "用户名";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 68);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "账号类型";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 38);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "密码";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(105, 35);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(482, 26);
            this.tb_password.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.user_apn);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(593, 444);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "APN";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // user_apn
            // 
            this.user_apn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_apn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_apn.FormattingEnabled = true;
            this.user_apn.Location = new System.Drawing.Point(3, 3);
            this.user_apn.MultiColumn = true;
            this.user_apn.Name = "user_apn";
            this.user_apn.Size = new System.Drawing.Size(587, 438);
            this.user_apn.TabIndex = 6;
            // 
            // btn_user_cancel
            // 
            this.btn_user_cancel.Location = new System.Drawing.Point(492, 483);
            this.btn_user_cancel.Name = "btn_user_cancel";
            this.btn_user_cancel.Size = new System.Drawing.Size(106, 34);
            this.btn_user_cancel.TabIndex = 8;
            this.btn_user_cancel.Text = "取消";
            this.btn_user_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_user_save
            // 
            this.btn_user_save.Location = new System.Drawing.Point(380, 483);
            this.btn_user_save.Name = "btn_user_save";
            this.btn_user_save.Size = new System.Drawing.Size(106, 34);
            this.btn_user_save.TabIndex = 7;
            this.btn_user_save.Text = "保存";
            this.btn_user_save.UseVisualStyleBackColor = true;
            this.btn_user_save.Click += new System.EventHandler(this.btn_user_save_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_script_import);
            this.tabPage1.Controls.Add(this.btn_script_run);
            this.tabPage1.Controls.Add(this.btn_script_gen);
            this.tabPage1.Controls.Add(this.tb_script);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(776, 528);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "脚本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_script_run
            // 
            this.btn_script_run.Location = new System.Drawing.Point(693, 487);
            this.btn_script_run.Name = "btn_script_run";
            this.btn_script_run.Size = new System.Drawing.Size(75, 34);
            this.btn_script_run.TabIndex = 2;
            this.btn_script_run.Text = "运行脚本";
            this.btn_script_run.UseVisualStyleBackColor = true;
            this.btn_script_run.Click += new System.EventHandler(this.btn_script_run_Click);
            // 
            // btn_script_gen
            // 
            this.btn_script_gen.Location = new System.Drawing.Point(612, 487);
            this.btn_script_gen.Name = "btn_script_gen";
            this.btn_script_gen.Size = new System.Drawing.Size(75, 34);
            this.btn_script_gen.TabIndex = 1;
            this.btn_script_gen.Text = "更新脚本";
            this.btn_script_gen.UseVisualStyleBackColor = true;
            this.btn_script_gen.Click += new System.EventHandler(this.btn_script_gen_Click);
            // 
            // tb_script
            // 
            this.tb_script.Location = new System.Drawing.Point(3, 3);
            this.tb_script.Multiline = true;
            this.tb_script.Name = "tb_script";
            this.tb_script.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_script.Size = new System.Drawing.Size(765, 478);
            this.tb_script.TabIndex = 0;
            this.tb_script.WordWrap = false;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // btn_script_import
            // 
            this.btn_script_import.Location = new System.Drawing.Point(531, 487);
            this.btn_script_import.Name = "btn_script_import";
            this.btn_script_import.Size = new System.Drawing.Size(75, 33);
            this.btn_script_import.TabIndex = 3;
            this.btn_script_import.Text = "导入脚本";
            this.btn_script_import.UseVisualStyleBackColor = true;
            this.btn_script_import.Click += new System.EventHandler(this.btn_script_import_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(804, 604);
            this.MinimumSize = new System.Drawing.Size(804, 604);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APN容灾系统管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arAPN)).EndInit();
            this.m_apn.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tab_apn.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.VPNAdmin.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tc_vpn.ResumeLayout(false);
            this.tp_vpn_set.ResumeLayout(false);
            this.tp_vpn_set.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.APNAdmin.ResumeLayout(false);
            this.UserAdmin.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arAPNBindingSource)).EndInit();
            this.tab_user.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_apn_filter;
        private System.Windows.Forms.ListBox list_apn;
        private System.Windows.Forms.Button btn_add_apn;
        private arAPN arAPN;
        private System.Windows.Forms.BindingSource apnBindingSource;
        private arAPNTableAdapters.ApnTableAdapter apnTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage APNAdmin;
        private System.Windows.Forms.TabPage UserAdmin;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_user_filter;
        private System.Windows.Forms.ListBox list_user;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.BindingSource arAPNBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private arAPNTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ContextMenuStrip m_apn;
        private System.Windows.Forms.ToolStripMenuItem btn_apn_delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.CheckedListBox user_apn;
        private System.Windows.Forms.TabControl tab_apn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_apn_sim_ip;
        private System.Windows.Forms.TextBox tb_apn_apn_name;
        private System.Windows.Forms.Button btn_apn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_apn_cancel;
        private System.Windows.Forms.CheckedListBox clb_apn_user;
        private System.Windows.Forms.Button btn_user_cancel;
        private System.Windows.Forms.Button btn_user_save;
        private System.Windows.Forms.TabControl tab_user;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage VPNAdmin;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_f_vpn;
        private System.Windows.Forms.ListBox lb_vpn;
        private System.Windows.Forms.Button btn_add_vpn;
        private System.Windows.Forms.TabControl tc_vpn;
        private System.Windows.Forms.TabPage tp_vpn_set;
        private System.Windows.Forms.TabPage tp_vpn_apn;
        private System.Windows.Forms.TextBox tb_vpn_route;
        private System.Windows.Forms.TextBox tb_vpn_ipaddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_vpn_destination;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_vpn_source;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_vpn_vpn_name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_vpn_cancel;
        private System.Windows.Forms.Button btn_vpn_save;
        private System.Windows.Forms.Button btn_vpn_preview;
        private System.Windows.Forms.Label l_vpn_script;
        private System.Windows.Forms.TextBox tb_vpn_memo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cb_apn_is_static;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_apn_vpn1_id;
        private System.Windows.Forms.TextBox tb_apn_memo;
        private System.Windows.Forms.TextBox tb_apn_contact;
        private System.Windows.Forms.TextBox tb_apn_tunnel_name;
        private System.Windows.Forms.TextBox tb_apn_ggsn_gnif;
        private System.Windows.Forms.TextBox tb_apn_ggsn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_vpn_source1;
        private System.Windows.Forms.TextBox tb_vpn_destination1;
        private System.Windows.Forms.TextBox tb_vpn_ipaddress1;
        private System.Windows.Forms.TextBox tb_vpn_route1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_apn_preview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_script_run;
        private System.Windows.Forms.Button btn_script_gen;
        private System.Windows.Forms.TextBox tb_script;
        private System.Windows.Forms.Button btn_apn_dns;
        private System.Windows.Forms.TextBox tb_apn_serverip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lb_apn_vpn_source;
        private System.Windows.Forms.Label lb_apn_vpn_destination;
        private System.Windows.Forms.Label lb_apn_vpn_ipaddress;
        private System.Windows.Forms.Label lb_apn_vpn_route;
        private System.Windows.Forms.Label lb_apn_vpn_route1;
        private System.Windows.Forms.Label lb_apn_vpn_ipaddress1;
        private System.Windows.Forms.Label lb_apn_vpn_destination1;
        private System.Windows.Forms.Label lb_apn_vpn_source1;
        private System.Windows.Forms.Button btn_script_import;
    }
}