﻿namespace AppMonitor.Froms
{
    partial class SpringBootMonitorForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.自定义命令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.定时任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.条件任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_build = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.pic_run_state = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.custom_btn = new System.Windows.Forms.LinkLabel();
            this.customShellListView = new CCWin.SkinControl.SkinListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shellView = new CCWin.SkinControl.SkinTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_pro_visit_url = new System.Windows.Forms.TextBox();
            this.l_appname = new System.Windows.Forms.TextBox();
            this.l_source_path = new System.Windows.Forms.TextBox();
            this.l_ctl_path = new System.Windows.Forms.TextBox();
            this.l_build_path = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_run_state)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自定义命令ToolStripMenuItem,
            this.toolStripSeparator1,
            this.定时任务ToolStripMenuItem,
            this.条件任务ToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(137, 76);
            // 
            // 自定义命令ToolStripMenuItem
            // 
            this.自定义命令ToolStripMenuItem.Name = "自定义命令ToolStripMenuItem";
            this.自定义命令ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.自定义命令ToolStripMenuItem.Text = "自定义脚本";
            this.自定义命令ToolStripMenuItem.Click += new System.EventHandler(this.自定义命令ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // 定时任务ToolStripMenuItem
            // 
            this.定时任务ToolStripMenuItem.Name = "定时任务ToolStripMenuItem";
            this.定时任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.定时任务ToolStripMenuItem.Text = "定时任务";
            this.定时任务ToolStripMenuItem.Click += new System.EventHandler(this.CustomTimeTask_Click);
            // 
            // 条件任务ToolStripMenuItem
            // 
            this.条件任务ToolStripMenuItem.Name = "条件任务ToolStripMenuItem";
            this.条件任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.条件任务ToolStripMenuItem.Text = "条件任务";
            this.条件任务ToolStripMenuItem.Click += new System.EventHandler(this.条件任务ToolStripMenuItem_Click);
            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;
            this.skinToolTip1.ToolTipTitle = "AppMonitor";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "立即检测";
            this.skinToolTip1.SetToolTip(this.button5, "立即检测程序运行是否正常");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Enabled = false;
            this.btn_run.Location = new System.Drawing.Point(631, 193);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(65, 26);
            this.btn_run.TabIndex = 9;
            this.btn_run.Text = "运行";
            this.skinToolTip1.SetToolTip(this.btn_run, "手动运行脚本");
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(273, 25);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(80, 28);
            this.btn_restart.TabIndex = 7;
            this.btn_restart.Text = "重启";
            this.skinToolTip1.SetToolTip(this.btn_restart, "重启程序，会先停止程序然后再启动程序");
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_build
            // 
            this.btn_build.Location = new System.Drawing.Point(19, 25);
            this.btn_build.Name = "btn_build";
            this.btn_build.Size = new System.Drawing.Size(86, 28);
            this.btn_build.TabIndex = 8;
            this.btn_build.Text = "更新并编译";
            this.skinToolTip1.SetToolTip(this.btn_build, "构建程序，从SVN更新最新版本并编译");
            this.btn_build.UseVisualStyleBackColor = true;
            this.btn_build.Click += new System.EventHandler(this.btn_build_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(121, 25);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(60, 28);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "启动";
            this.skinToolTip1.SetToolTip(this.btn_start, "启动程序，如果程序未停止或导致重复启动");
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(197, 25);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(60, 28);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "停止";
            this.skinToolTip1.SetToolTip(this.btn_stop, "停止程序");
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // pic_run_state
            // 
            this.pic_run_state.BackgroundImage = global::AppMonitor.Properties.Resources.gray_light_48;
            this.pic_run_state.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_run_state.Location = new System.Drawing.Point(31, 25);
            this.pic_run_state.Name = "pic_run_state";
            this.pic_run_state.Size = new System.Drawing.Size(48, 48);
            this.pic_run_state.TabIndex = 4;
            this.pic_run_state.TabStop = false;
            this.skinToolTip1.SetToolTip(this.pic_run_state, "未检测");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(709, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "访问";
            this.skinToolTip1.SetToolTip(this.linkLabel1, "在默认浏览器中打开项目首页地址");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.pic_run_state);
            this.groupBox2.Controls.Add(this.label_status);
            this.groupBox2.Location = new System.Drawing.Point(8, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 331);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "状态监控";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(4, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "SpringBoot";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(59, 6);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(758, 2);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.custom_btn);
            this.groupBox4.Controls.Add(this.customShellListView);
            this.groupBox4.Controls.Add(this.shellView);
            this.groupBox4.Controls.Add(this.btn_run);
            this.groupBox4.Location = new System.Drawing.Point(107, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(701, 223);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "扩展功能";
            // 
            // custom_btn
            // 
            this.custom_btn.AutoSize = true;
            this.custom_btn.LinkColor = System.Drawing.Color.Blue;
            this.custom_btn.Location = new System.Drawing.Point(67, 1);
            this.custom_btn.Name = "custom_btn";
            this.custom_btn.Size = new System.Drawing.Size(41, 12);
            this.custom_btn.TabIndex = 15;
            this.custom_btn.TabStop = true;
            this.custom_btn.Text = "自定义";
            this.skinToolTip1.SetToolTip(this.custom_btn, "自定义Shell、Task");
            this.custom_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            // 
            // customShellListView
            // 
            this.customShellListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customShellListView.BorderColor = System.Drawing.Color.LightGray;
            this.customShellListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.customShellListView.FullRowSelect = true;
            this.customShellListView.GridLines = true;
            this.customShellListView.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customShellListView.Location = new System.Drawing.Point(8, 20);
            this.customShellListView.MultiSelect = false;
            this.customShellListView.Name = "customShellListView";
            this.customShellListView.OwnerDraw = true;
            this.customShellListView.RowBackColor2 = System.Drawing.Color.White;
            this.customShellListView.SelectedColor = System.Drawing.Color.SkyBlue;
            this.customShellListView.Size = new System.Drawing.Size(284, 194);
            this.customShellListView.TabIndex = 10;
            this.customShellListView.UseCompatibleStateImageBehavior = false;
            this.customShellListView.View = System.Windows.Forms.View.Details;
            this.customShellListView.SelectedIndexChanged += new System.EventHandler(this.customShellListView_SelectedIndexChanged);
            this.customShellListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.customShellListView_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类型";
            this.columnHeader3.Width = 100;
            // 
            // shellView
            // 
            this.shellView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shellView.BackColor = System.Drawing.Color.Transparent;
            this.shellView.DownBack = null;
            this.shellView.Icon = null;
            this.shellView.IconIsButton = false;
            this.shellView.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.shellView.IsPasswordChat = '\0';
            this.shellView.IsSystemPasswordChar = false;
            this.shellView.Lines = new string[0];
            this.shellView.Location = new System.Drawing.Point(295, 21);
            this.shellView.Margin = new System.Windows.Forms.Padding(0);
            this.shellView.MaxLength = 32767;
            this.shellView.MinimumSize = new System.Drawing.Size(28, 28);
            this.shellView.MouseBack = null;
            this.shellView.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.shellView.Multiline = true;
            this.shellView.Name = "shellView";
            this.shellView.NormlBack = null;
            this.shellView.Padding = new System.Windows.Forms.Padding(5);
            this.shellView.ReadOnly = false;
            this.shellView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.shellView.Size = new System.Drawing.Size(400, 168);
            // 
            // 
            // 
            this.shellView.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shellView.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellView.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.shellView.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.shellView.SkinTxt.Multiline = true;
            this.shellView.SkinTxt.Name = "BaseText";
            this.shellView.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.shellView.SkinTxt.Size = new System.Drawing.Size(390, 158);
            this.shellView.SkinTxt.TabIndex = 0;
            this.shellView.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.shellView.SkinTxt.WaterText = "";
            this.shellView.TabIndex = 0;
            this.shellView.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shellView.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.shellView.WaterText = "";
            this.shellView.WordWrap = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_restart);
            this.groupBox3.Controls.Add(this.btn_build);
            this.groupBox3.Controls.Add(this.btn_start);
            this.groupBox3.Controls.Add(this.btn_stop);
            this.groupBox3.Location = new System.Drawing.Point(107, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(701, 76);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基础功能";
            // 
            // label_status
            // 
            this.label_status.Location = new System.Drawing.Point(17, 83);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(79, 12);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "检测中...";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.l_pro_visit_url);
            this.groupBox1.Controls.Add(this.l_appname);
            this.groupBox1.Controls.Add(this.l_source_path);
            this.groupBox1.Controls.Add(this.l_ctl_path);
            this.groupBox1.Controls.Add(this.l_build_path);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // l_pro_visit_url
            // 
            this.l_pro_visit_url.BackColor = System.Drawing.SystemColors.Control;
            this.l_pro_visit_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_pro_visit_url.Font = new System.Drawing.Font("宋体", 9F);
            this.l_pro_visit_url.Location = new System.Drawing.Point(444, 29);
            this.l_pro_visit_url.Name = "l_pro_visit_url";
            this.l_pro_visit_url.Size = new System.Drawing.Size(259, 14);
            this.l_pro_visit_url.TabIndex = 20;
            // 
            // l_appname
            // 
            this.l_appname.BackColor = System.Drawing.SystemColors.Control;
            this.l_appname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_appname.Font = new System.Drawing.Font("宋体", 9F);
            this.l_appname.Location = new System.Drawing.Point(110, 28);
            this.l_appname.Name = "l_appname";
            this.l_appname.ReadOnly = true;
            this.l_appname.Size = new System.Drawing.Size(183, 14);
            this.l_appname.TabIndex = 19;
            // 
            // l_source_path
            // 
            this.l_source_path.BackColor = System.Drawing.SystemColors.Control;
            this.l_source_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_source_path.Font = new System.Drawing.Font("宋体", 9F);
            this.l_source_path.Location = new System.Drawing.Point(110, 59);
            this.l_source_path.Name = "l_source_path";
            this.l_source_path.ReadOnly = true;
            this.l_source_path.Size = new System.Drawing.Size(500, 14);
            this.l_source_path.TabIndex = 18;
            // 
            // l_ctl_path
            // 
            this.l_ctl_path.BackColor = System.Drawing.SystemColors.Control;
            this.l_ctl_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_ctl_path.Font = new System.Drawing.Font("宋体", 9F);
            this.l_ctl_path.Location = new System.Drawing.Point(110, 92);
            this.l_ctl_path.Name = "l_ctl_path";
            this.l_ctl_path.ReadOnly = true;
            this.l_ctl_path.Size = new System.Drawing.Size(500, 14);
            this.l_ctl_path.TabIndex = 17;
            // 
            // l_build_path
            // 
            this.l_build_path.BackColor = System.Drawing.SystemColors.Control;
            this.l_build_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_build_path.Font = new System.Drawing.Font("宋体", 9F);
            this.l_build_path.Location = new System.Drawing.Point(110, 128);
            this.l_build_path.Name = "l_build_path";
            this.l_build_path.ReadOnly = true;
            this.l_build_path.Size = new System.Drawing.Size(500, 14);
            this.l_build_path.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "项目访问地址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "项目名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "控制脚本：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "构建脚本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "代码路径：";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(114, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem2.Text = "Edit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem3.Text = "Delete";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // SpringBootMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpringBootMonitorForm";
            this.Text = "MonitorWorkForm";
            this.Load += new System.EventHandler(this.SpringBootMonitorForm_Load);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_run_state)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.PictureBox pic_run_state;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_build;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox l_build_path;
        private System.Windows.Forms.TextBox l_ctl_path;
        private System.Windows.Forms.TextBox l_source_path;
        private System.Windows.Forms.TextBox l_appname;
        private System.Windows.Forms.TextBox l_pro_visit_url;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 自定义命令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btn_run;
        private CCWin.SkinControl.SkinTextBox shellView;
        private CCWin.SkinControl.SkinListView customShellListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem 定时任务ToolStripMenuItem;
        private CCWin.SkinToolTip skinToolTip1;
        private System.Windows.Forms.ToolStripMenuItem 条件任务ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel custom_btn;
    }
}