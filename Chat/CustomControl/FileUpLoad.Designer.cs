namespace Chat.CustomControl
{
    partial class FileUpLoad
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MsgTime_label = new System.Windows.Forms.Label();
            this.Message_roundPanel = new myControlLibrary.RoundPanel(this.components);
            this.FileType_label = new System.Windows.Forms.Label();
            this.FileSize_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileName_label = new System.Windows.Forms.Label();
            this.FileTypeImg_panel = new System.Windows.Forms.Panel();
            this.Option_button = new System.Windows.Forms.Button();
            this.OpenFile_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Option_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UploadDone_label = new System.Windows.Forms.Label();
            this.UserHeade_panel = new System.Windows.Forms.Panel();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转发ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile_saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Message_roundPanel.SuspendLayout();
            this.Option_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsgTime_label
            // 
            this.MsgTime_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgTime_label.AutoSize = true;
            this.MsgTime_label.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.MsgTime_label.ForeColor = System.Drawing.Color.Gray;
            this.MsgTime_label.Location = new System.Drawing.Point(351, 9);
            this.MsgTime_label.Name = "MsgTime_label";
            this.MsgTime_label.Size = new System.Drawing.Size(0, 11);
            this.MsgTime_label.TabIndex = 7;
            // 
            // Message_roundPanel
            // 
            this.Message_roundPanel._setRoundRadius = 5;
            this.Message_roundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message_roundPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.Message_roundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Message_roundPanel.Controls.Add(this.UploadDone_label);
            this.Message_roundPanel.Controls.Add(this.FileType_label);
            this.Message_roundPanel.Controls.Add(this.FileSize_label);
            this.Message_roundPanel.Controls.Add(this.label3);
            this.Message_roundPanel.Controls.Add(this.label2);
            this.Message_roundPanel.Controls.Add(this.label1);
            this.Message_roundPanel.Controls.Add(this.FileName_label);
            this.Message_roundPanel.Controls.Add(this.FileTypeImg_panel);
            this.Message_roundPanel.Controls.Add(this.Option_button);
            this.Message_roundPanel.Controls.Add(this.OpenFile_button);
            this.Message_roundPanel.Controls.Add(this.progressBar1);
            this.Message_roundPanel.Location = new System.Drawing.Point(128, 20);
            this.Message_roundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Message_roundPanel.Name = "Message_roundPanel";
            this.Message_roundPanel.Size = new System.Drawing.Size(336, 81);
            this.Message_roundPanel.TabIndex = 6;
            // 
            // FileType_label
            // 
            this.FileType_label.AutoSize = true;
            this.FileType_label.ForeColor = System.Drawing.Color.White;
            this.FileType_label.Location = new System.Drawing.Point(104, 48);
            this.FileType_label.Name = "FileType_label";
            this.FileType_label.Size = new System.Drawing.Size(41, 12);
            this.FileType_label.TabIndex = 18;
            this.FileType_label.Text = "label1";
            // 
            // FileSize_label
            // 
            this.FileSize_label.AutoSize = true;
            this.FileSize_label.ForeColor = System.Drawing.Color.White;
            this.FileSize_label.Location = new System.Drawing.Point(104, 25);
            this.FileSize_label.Name = "FileSize_label";
            this.FileSize_label.Size = new System.Drawing.Size(41, 12);
            this.FileSize_label.TabIndex = 17;
            this.FileSize_label.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "大小";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "名称";
            // 
            // FileName_label
            // 
            this.FileName_label.AutoSize = true;
            this.FileName_label.ForeColor = System.Drawing.Color.White;
            this.FileName_label.Location = new System.Drawing.Point(104, 3);
            this.FileName_label.Name = "FileName_label";
            this.FileName_label.Size = new System.Drawing.Size(41, 12);
            this.FileName_label.TabIndex = 11;
            this.FileName_label.Text = "label1";
            // 
            // FileTypeImg_panel
            // 
            this.FileTypeImg_panel.BackColor = System.Drawing.Color.White;
            this.FileTypeImg_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FileTypeImg_panel.Location = new System.Drawing.Point(3, 3);
            this.FileTypeImg_panel.Name = "FileTypeImg_panel";
            this.FileTypeImg_panel.Size = new System.Drawing.Size(57, 57);
            this.FileTypeImg_panel.TabIndex = 10;
            // 
            // Option_button
            // 
            this.Option_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Option_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Option_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Option_button.FlatAppearance.BorderSize = 0;
            this.Option_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Option_button.ForeColor = System.Drawing.Color.White;
            this.Option_button.Location = new System.Drawing.Point(287, 58);
            this.Option_button.Name = "Option_button";
            this.Option_button.Size = new System.Drawing.Size(49, 23);
            this.Option_button.TabIndex = 9;
            this.Option_button.Text = "选项";
            this.Option_button.UseVisualStyleBackColor = false;
            this.Option_button.Click += new System.EventHandler(this.Option_button_Click);
            // 
            // OpenFile_button
            // 
            this.OpenFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFile_button.FlatAppearance.BorderSize = 0;
            this.OpenFile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile_button.ForeColor = System.Drawing.Color.White;
            this.OpenFile_button.Location = new System.Drawing.Point(248, 58);
            this.OpenFile_button.Name = "OpenFile_button";
            this.OpenFile_button.Size = new System.Drawing.Size(41, 23);
            this.OpenFile_button.TabIndex = 8;
            this.OpenFile_button.Text = "打开";
            this.OpenFile_button.UseVisualStyleBackColor = true;
            this.OpenFile_button.Click += new System.EventHandler(this.OpenFile_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.progressBar1.Location = new System.Drawing.Point(62, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(189, 5);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // UserName_label
            // 
            this.UserName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(486, 59);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(35, 12);
            this.UserName_label.TabIndex = 5;
            this.UserName_label.Text = "shuai";
            // 
            // Option_contextMenuStrip
            // 
            this.Option_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件夹ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.转发ToolStripMenuItem});
            this.Option_contextMenuStrip.Name = "Option_contextMenuStrip";
            this.Option_contextMenuStrip.Size = new System.Drawing.Size(137, 70);
            // 
            // UploadDone_label
            // 
            this.UploadDone_label.AutoSize = true;
            this.UploadDone_label.ForeColor = System.Drawing.Color.White;
            this.UploadDone_label.Location = new System.Drawing.Point(3, 66);
            this.UploadDone_label.Name = "UploadDone_label";
            this.UploadDone_label.Size = new System.Drawing.Size(53, 12);
            this.UploadDone_label.TabIndex = 19;
            this.UploadDone_label.Text = "上传进度";
            // 
            // UserHeade_panel
            // 
            this.UserHeade_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserHeade_panel.BackgroundImage = global::Chat.Properties.Resources.me_photo;
            this.UserHeade_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserHeade_panel.Location = new System.Drawing.Point(480, 8);
            this.UserHeade_panel.Name = "UserHeade_panel";
            this.UserHeade_panel.Size = new System.Drawing.Size(45, 45);
            this.UserHeade_panel.TabIndex = 4;
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Image = global::Chat.Properties.Resources.file;
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Image = global::Chat.Properties.Resources.save;
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 转发ToolStripMenuItem
            // 
            this.转发ToolStripMenuItem.Image = global::Chat.Properties.Resources.转发;
            this.转发ToolStripMenuItem.Name = "转发ToolStripMenuItem";
            this.转发ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.转发ToolStripMenuItem.Text = "转发";
            this.转发ToolStripMenuItem.Click += new System.EventHandler(this.转发ToolStripMenuItem_Click);
            // 
            // SaveFile_saveFileDialog
            // 
            this.SaveFile_saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFile_saveFileDialog_FileOk);
            // 
            // FileUpLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MsgTime_label);
            this.Controls.Add(this.Message_roundPanel);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.UserHeade_panel);
            this.Name = "FileUpLoad";
            this.Size = new System.Drawing.Size(535, 116);
            this.Message_roundPanel.ResumeLayout(false);
            this.Message_roundPanel.PerformLayout();
            this.Option_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MsgTime_label;
        private myControlLibrary.RoundPanel Message_roundPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Panel UserHeade_panel;
        private System.Windows.Forms.Button OpenFile_button;
        private System.Windows.Forms.Button Option_button;
        private System.Windows.Forms.Panel FileTypeImg_panel;
        private System.Windows.Forms.Label FileName_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FileType_label;
        private System.Windows.Forms.Label FileSize_label;
        private System.Windows.Forms.ContextMenuStrip Option_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转发ToolStripMenuItem;
        private System.Windows.Forms.Label UploadDone_label;
        private System.Windows.Forms.SaveFileDialog SaveFile_saveFileDialog;
    }
}
