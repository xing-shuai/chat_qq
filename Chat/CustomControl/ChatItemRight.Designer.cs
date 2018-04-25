namespace Chat.CustomControl
{
    partial class ChatItemRight
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
            this.UserHeade_panel = new System.Windows.Forms.Panel();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Message_roundPanel = new myControlLibrary.RoundPanel(this.components);
            this.Msg_textBox = new System.Windows.Forms.RichTextBox();
            this.MsgTime_label = new System.Windows.Forms.Label();
            this.Message_roundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserHeade_panel
            // 
            this.UserHeade_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserHeade_panel.BackgroundImage = global::Chat.Properties.Resources.me_photo;
            this.UserHeade_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserHeade_panel.Location = new System.Drawing.Point(410, 9);
            this.UserHeade_panel.Name = "UserHeade_panel";
            this.UserHeade_panel.Size = new System.Drawing.Size(45, 45);
            this.UserHeade_panel.TabIndex = 0;
            // 
            // UserName_label
            // 
            this.UserName_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName_label.AutoSize = true;
            this.UserName_label.Location = new System.Drawing.Point(416, 60);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(35, 12);
            this.UserName_label.TabIndex = 1;
            this.UserName_label.Text = "shuai";
            // 
            // Message_roundPanel
            // 
            this.Message_roundPanel._setRoundRadius = 5;
            this.Message_roundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message_roundPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Message_roundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Message_roundPanel.Controls.Add(this.Msg_textBox);
            this.Message_roundPanel.Location = new System.Drawing.Point(152, 24);
            this.Message_roundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Message_roundPanel.Name = "Message_roundPanel";
            this.Message_roundPanel.Size = new System.Drawing.Size(242, 40);
            this.Message_roundPanel.TabIndex = 2;
            // 
            // Msg_textBox
            // 
            this.Msg_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Msg_textBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Msg_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Msg_textBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Msg_textBox.ForeColor = System.Drawing.Color.White;
            this.Msg_textBox.Location = new System.Drawing.Point(3, 5);
            this.Msg_textBox.MaximumSize = new System.Drawing.Size(236, 1000);
            this.Msg_textBox.MinimumSize = new System.Drawing.Size(30, 30);
            this.Msg_textBox.Name = "Msg_textBox";
            this.Msg_textBox.ReadOnly = true;
            this.Msg_textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Msg_textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Msg_textBox.Size = new System.Drawing.Size(236, 30);
            this.Msg_textBox.TabIndex = 0;
            this.Msg_textBox.Text = "";
            // 
            // MsgTime_label
            // 
            this.MsgTime_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MsgTime_label.AutoSize = true;
            this.MsgTime_label.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.MsgTime_label.ForeColor = System.Drawing.Color.Gray;
            this.MsgTime_label.Location = new System.Drawing.Point(281, 10);
            this.MsgTime_label.Name = "MsgTime_label";
            this.MsgTime_label.Size = new System.Drawing.Size(0, 11);
            this.MsgTime_label.TabIndex = 3;
            // 
            // ChatItemRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MsgTime_label);
            this.Controls.Add(this.Message_roundPanel);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.UserHeade_panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChatItemRight";
            this.Size = new System.Drawing.Size(458, 79);
            this.Message_roundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UserHeade_panel;
        private System.Windows.Forms.Label UserName_label;
        private myControlLibrary.RoundPanel Message_roundPanel;
        private System.Windows.Forms.Label MsgTime_label;
        private System.Windows.Forms.RichTextBox Msg_textBox;
    }
}
