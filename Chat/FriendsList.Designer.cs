namespace Chat
{
    partial class FriendsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.setting_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.files_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.message_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.share_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Exit_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Hide_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StateChange_comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.head_panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HistoryChatList_tabPage = new System.Windows.Forms.TabPage();
            this.HistoryChatList_ChatListView = new _CUSTOM_CONTROLS.ChatListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Friends_chatListBox = new _CUSTOM_CONTROLS.ChatListBox();
            this.ChatRoom_tabPage = new System.Windows.Forms.TabPage();
            this.CharRoom_chatListView = new _CUSTOM_CONTROLS.ChatListView();
            this.MouseRightMenu_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nihaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建聊天室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.查看资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消息记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.会话置顶ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除当前会话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改备注ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.刷新列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FriendList_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskMenu_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoHide_timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.HistoryChatList_tabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ChatRoom_tabPage.SuspendLayout();
            this.MouseRightMenu_contextMenuStrip.SuspendLayout();
            this.TaskMenu_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setting_toolStripButton,
            this.files_toolStripButton,
            this.message_toolStripButton,
            this.share_toolStripButton,
            this.Exit_toolStripButton,
            this.Hide_toolStripButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(4, 540);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(164, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // setting_toolStripButton
            // 
            this.setting_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setting_toolStripButton.Image = global::Chat.Properties.Resources.set;
            this.setting_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setting_toolStripButton.Name = "setting_toolStripButton";
            this.setting_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.setting_toolStripButton.Text = "设置";
            this.setting_toolStripButton.Click += new System.EventHandler(this.setting_toolStripButton_Click);
            // 
            // files_toolStripButton
            // 
            this.files_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.files_toolStripButton.Image = global::Chat.Properties.Resources.file;
            this.files_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.files_toolStripButton.Name = "files_toolStripButton";
            this.files_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.files_toolStripButton.Text = "文件";
            this.files_toolStripButton.Click += new System.EventHandler(this.files_toolStripButton_Click);
            // 
            // message_toolStripButton
            // 
            this.message_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.message_toolStripButton.Image = global::Chat.Properties.Resources.通知;
            this.message_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.message_toolStripButton.Name = "message_toolStripButton";
            this.message_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.message_toolStripButton.Text = "消息";
            // 
            // share_toolStripButton
            // 
            this.share_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.share_toolStripButton.Image = global::Chat.Properties.Resources.分享;
            this.share_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.share_toolStripButton.Name = "share_toolStripButton";
            this.share_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.share_toolStripButton.Text = "分享";
            // 
            // Exit_toolStripButton
            // 
            this.Exit_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit_toolStripButton.Image = global::Chat.Properties.Resources.退出;
            this.Exit_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit_toolStripButton.Name = "Exit_toolStripButton";
            this.Exit_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Exit_toolStripButton.Text = "退出";
            this.Exit_toolStripButton.Click += new System.EventHandler(this.Exit_toolStripButton_Click);
            // 
            // Hide_toolStripButton
            // 
            this.Hide_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Hide_toolStripButton.Image = global::Chat.Properties.Resources.隐藏;
            this.Hide_toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Hide_toolStripButton.Name = "Hide_toolStripButton";
            this.Hide_toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Hide_toolStripButton.Text = "隐藏";
            this.Hide_toolStripButton.Click += new System.EventHandler(this.Hide_toolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Chat.Properties.Resources.search;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "查找好友";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StateChange_comboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.head_panel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // StateChange_comboBox
            // 
            this.StateChange_comboBox.FormattingEnabled = true;
            this.StateChange_comboBox.Items.AddRange(new object[] {
            "在线",
            "隐身",
            "忙碌",
            "离开"});
            this.StateChange_comboBox.Location = new System.Drawing.Point(151, 11);
            this.StateChange_comboBox.Name = "StateChange_comboBox";
            this.StateChange_comboBox.Size = new System.Drawing.Size(52, 20);
            this.StateChange_comboBox.TabIndex = 9;
            this.StateChange_comboBox.Text = "在线";
            this.StateChange_comboBox.SelectedIndexChanged += new System.EventHandler(this.StateChange_comboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Chat.Properties.Resources.科学;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(121, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Chat.Properties.Resources.娱乐;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(92, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(0, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 21);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // head_panel
            // 
            this.head_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.head_panel.Location = new System.Drawing.Point(6, 14);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(70, 70);
            this.head_panel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.HistoryChatList_tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.ChatRoom_tabPage);
            this.tabControl1.Location = new System.Drawing.Point(4, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 415);
            this.tabControl1.TabIndex = 3;
            // 
            // HistoryChatList_tabPage
            // 
            this.HistoryChatList_tabPage.Controls.Add(this.HistoryChatList_ChatListView);
            this.HistoryChatList_tabPage.Location = new System.Drawing.Point(4, 22);
            this.HistoryChatList_tabPage.Name = "HistoryChatList_tabPage";
            this.HistoryChatList_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryChatList_tabPage.Size = new System.Drawing.Size(292, 389);
            this.HistoryChatList_tabPage.TabIndex = 0;
            this.HistoryChatList_tabPage.Text = "聊天历史";
            this.HistoryChatList_tabPage.UseVisualStyleBackColor = true;
            // 
            // HistoryChatList_ChatListView
            // 
            this.HistoryChatList_ChatListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryChatList_ChatListView.BackColor = System.Drawing.Color.White;
            this.HistoryChatList_ChatListView.ForeColor = System.Drawing.Color.DarkOrange;
            this.HistoryChatList_ChatListView.IconSizeMode = _CUSTOM_CONTROLS._ChatListBox.ChatListItemIcon.Large;
            this.HistoryChatList_ChatListView.Location = new System.Drawing.Point(2, 3);
            this.HistoryChatList_ChatListView.Name = "HistoryChatList_ChatListView";
            this.HistoryChatList_ChatListView.ScrollArrowBackColor = System.Drawing.Color.LightGray;
            this.HistoryChatList_ChatListView.ScrollSliderDefaultColor = System.Drawing.Color.Gainsboro;
            this.HistoryChatList_ChatListView.Size = new System.Drawing.Size(290, 383);
            this.HistoryChatList_ChatListView.TabIndex = 0;
            this.HistoryChatList_ChatListView.Text = "componentText1";
            this.HistoryChatList_ChatListView.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListView.ChatListEventHandler(this.HistoryChatList_ChatListView_DoubleClickSubItem);
            this.HistoryChatList_ChatListView.MouseRightClickSubItem += new _CUSTOM_CONTROLS.ChatListView.ChatListEventHandler(this.HistoryChatList_ChatListView_MouseRightClickSubItem);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Friends_chatListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "好友列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Friends_chatListBox
            // 
            this.Friends_chatListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Friends_chatListBox.BackColor = System.Drawing.Color.White;
            this.Friends_chatListBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.Friends_chatListBox.IconSizeMode = _CUSTOM_CONTROLS._ChatListBox.ChatListItemIcon.Large;
            this.Friends_chatListBox.Location = new System.Drawing.Point(4, 3);
            this.Friends_chatListBox.Name = "Friends_chatListBox";
            this.Friends_chatListBox.ScrollArrowBackColor = System.Drawing.Color.LightGray;
            this.Friends_chatListBox.ScrollSliderDefaultColor = System.Drawing.Color.LightGray;
            this.Friends_chatListBox.ScrollSliderDownColor = System.Drawing.Color.LightGray;
            this.Friends_chatListBox.Size = new System.Drawing.Size(288, 383);
            this.Friends_chatListBox.TabIndex = 3;
            this.Friends_chatListBox.Text = "chatListBox1";
            this.Friends_chatListBox.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListBox.ChatListEventHandler(this.Friends_chatListBox_DoubleClickSubItem);
            this.Friends_chatListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Friends_chatListBox_MouseClick);
            // 
            // ChatRoom_tabPage
            // 
            this.ChatRoom_tabPage.Controls.Add(this.CharRoom_chatListView);
            this.ChatRoom_tabPage.Location = new System.Drawing.Point(4, 22);
            this.ChatRoom_tabPage.Name = "ChatRoom_tabPage";
            this.ChatRoom_tabPage.Size = new System.Drawing.Size(292, 389);
            this.ChatRoom_tabPage.TabIndex = 2;
            this.ChatRoom_tabPage.Text = "聊天室";
            this.ChatRoom_tabPage.UseVisualStyleBackColor = true;
            // 
            // CharRoom_chatListView
            // 
            this.CharRoom_chatListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharRoom_chatListView.BackColor = System.Drawing.Color.White;
            this.CharRoom_chatListView.ForeColor = System.Drawing.Color.DarkOrange;
            this.CharRoom_chatListView.IconSizeMode = _CUSTOM_CONTROLS._ChatListBox.ChatListItemIcon.Large;
            this.CharRoom_chatListView.Location = new System.Drawing.Point(1, 3);
            this.CharRoom_chatListView.Name = "CharRoom_chatListView";
            this.CharRoom_chatListView.Size = new System.Drawing.Size(290, 383);
            this.CharRoom_chatListView.TabIndex = 1;
            this.CharRoom_chatListView.Text = "componentText1";
            this.CharRoom_chatListView.DoubleClickSubItem += new _CUSTOM_CONTROLS.ChatListView.ChatListEventHandler(this.CharRoom_chatListView_DoubleClickSubItem);
            this.CharRoom_chatListView.MouseRightClickSubItem += new _CUSTOM_CONTROLS.ChatListView.ChatListEventHandler(this.CharRoom_chatListView_MouseRightClickSubItem);
            // 
            // MouseRightMenu_contextMenuStrip
            // 
            this.MouseRightMenu_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nihaoToolStripMenuItem,
            this.创建聊天室ToolStripMenuItem,
            this.toolStripSeparator1,
            this.查看资料ToolStripMenuItem,
            this.消息记录ToolStripMenuItem,
            this.toolStripSeparator2,
            this.会话置顶ToolStripMenuItem,
            this.删除当前会话ToolStripMenuItem,
            this.修改备注ToolStripMenuItem,
            this.修改分组ToolStripMenuItem,
            this.toolStripSeparator3,
            this.刷新列表ToolStripMenuItem});
            this.MouseRightMenu_contextMenuStrip.Name = "contextMenuStrip1";
            this.MouseRightMenu_contextMenuStrip.Size = new System.Drawing.Size(149, 220);
            // 
            // nihaoToolStripMenuItem
            // 
            this.nihaoToolStripMenuItem.Image = global::Chat.Properties.Resources.chat;
            this.nihaoToolStripMenuItem.Name = "nihaoToolStripMenuItem";
            this.nihaoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nihaoToolStripMenuItem.Text = "发送消息";
            this.nihaoToolStripMenuItem.Click += new System.EventHandler(this.nihaoToolStripMenuItem_Click);
            // 
            // 创建聊天室ToolStripMenuItem
            // 
            this.创建聊天室ToolStripMenuItem.Image = global::Chat.Properties.Resources.群聊;
            this.创建聊天室ToolStripMenuItem.Name = "创建聊天室ToolStripMenuItem";
            this.创建聊天室ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.创建聊天室ToolStripMenuItem.Text = "创建聊天室";
            this.创建聊天室ToolStripMenuItem.Click += new System.EventHandler(this.创建聊天室ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // 查看资料ToolStripMenuItem
            // 
            this.查看资料ToolStripMenuItem.Image = global::Chat.Properties.Resources.info;
            this.查看资料ToolStripMenuItem.Name = "查看资料ToolStripMenuItem";
            this.查看资料ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看资料ToolStripMenuItem.Text = "查看资料";
            // 
            // 消息记录ToolStripMenuItem
            // 
            this.消息记录ToolStripMenuItem.Image = global::Chat.Properties.Resources.记录;
            this.消息记录ToolStripMenuItem.Name = "消息记录ToolStripMenuItem";
            this.消息记录ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.消息记录ToolStripMenuItem.Text = "消息记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // 会话置顶ToolStripMenuItem
            // 
            this.会话置顶ToolStripMenuItem.Image = global::Chat.Properties.Resources.置顶;
            this.会话置顶ToolStripMenuItem.Name = "会话置顶ToolStripMenuItem";
            this.会话置顶ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.会话置顶ToolStripMenuItem.Text = "会话置顶";
            // 
            // 删除当前会话ToolStripMenuItem
            // 
            this.删除当前会话ToolStripMenuItem.Image = global::Chat.Properties.Resources.删除;
            this.删除当前会话ToolStripMenuItem.Name = "删除当前会话ToolStripMenuItem";
            this.删除当前会话ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除当前会话ToolStripMenuItem.Text = "删除当前会话";
            this.删除当前会话ToolStripMenuItem.Click += new System.EventHandler(this.删除当前会话ToolStripMenuItem_Click);
            // 
            // 修改备注ToolStripMenuItem
            // 
            this.修改备注ToolStripMenuItem.Image = global::Chat.Properties.Resources.备注;
            this.修改备注ToolStripMenuItem.Name = "修改备注ToolStripMenuItem";
            this.修改备注ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改备注ToolStripMenuItem.Text = "修改备注";
            // 
            // 修改分组ToolStripMenuItem
            // 
            this.修改分组ToolStripMenuItem.Image = global::Chat.Properties.Resources.group;
            this.修改分组ToolStripMenuItem.Name = "修改分组ToolStripMenuItem";
            this.修改分组ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改分组ToolStripMenuItem.Text = "修改分组";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // 刷新列表ToolStripMenuItem
            // 
            this.刷新列表ToolStripMenuItem.Image = global::Chat.Properties.Resources.刷新;
            this.刷新列表ToolStripMenuItem.Name = "刷新列表ToolStripMenuItem";
            this.刷新列表ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.刷新列表ToolStripMenuItem.Text = "刷新列表";
            this.刷新列表ToolStripMenuItem.Click += new System.EventHandler(this.刷新列表ToolStripMenuItem_Click);
            // 
            // FriendList_notifyIcon
            // 
            this.FriendList_notifyIcon.ContextMenuStrip = this.TaskMenu_contextMenuStrip;
            this.FriendList_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("FriendList_notifyIcon.Icon")));
            this.FriendList_notifyIcon.Tag = "0";
            this.FriendList_notifyIcon.Text = "我的聊天程序";
            this.FriendList_notifyIcon.Visible = true;
            this.FriendList_notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FriendList_notifyIcon_MouseClick);
            // 
            // TaskMenu_contextMenuStrip
            // 
            this.TaskMenu_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.TaskMenu_contextMenuStrip.Name = "TaskMenu_contextMenuStrip";
            this.TaskMenu_contextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::Chat.Properties.Resources.退出;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // AutoHide_timer
            // 
            this.AutoHide_timer.Tick += new System.EventHandler(this.AutoHide_timer_Tick);
            // 
            // FriendsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 738);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(314, 400);
            this.Name = "FriendsList";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FriendsList_FormClosing);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.HistoryChatList_tabPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ChatRoom_tabPage.ResumeLayout(false);
            this.MouseRightMenu_contextMenuStrip.ResumeLayout(false);
            this.TaskMenu_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton setting_toolStripButton;
        private System.Windows.Forms.ToolStripButton files_toolStripButton;
        private System.Windows.Forms.ToolStripButton message_toolStripButton;
        private System.Windows.Forms.ToolStripButton share_toolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HistoryChatList_tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private _CUSTOM_CONTROLS.ChatListBox Friends_chatListBox;
        private _CUSTOM_CONTROLS.ChatListView HistoryChatList_ChatListView;
        private System.Windows.Forms.ContextMenuStrip MouseRightMenu_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nihaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 查看资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消息记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 会话置顶ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除当前会话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改备注ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Exit_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon FriendList_notifyIcon;
        private System.Windows.Forms.ToolStripButton Hide_toolStripButton;
        private System.Windows.Forms.ContextMenuStrip TaskMenu_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer AutoHide_timer;
        private System.Windows.Forms.ComboBox StateChange_comboBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage ChatRoom_tabPage;
        private _CUSTOM_CONTROLS.ChatListView CharRoom_chatListView;
        private System.Windows.Forms.ToolStripMenuItem 创建聊天室ToolStripMenuItem;
    }
}