namespace Chat.CustomControl
{
    partial class SearchFriendListItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddFriend_button = new System.Windows.Forms.Button();
            this.MoreInfo_button = new System.Windows.Forms.Button();
            this.Signature_label = new System.Windows.Forms.Label();
            this.NickName_label = new System.Windows.Forms.Label();
            this.UserHeadImg_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.AddFriend_button);
            this.panel1.Controls.Add(this.MoreInfo_button);
            this.panel1.Controls.Add(this.Signature_label);
            this.panel1.Controls.Add(this.NickName_label);
            this.panel1.Controls.Add(this.UserHeadImg_panel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // AddFriend_button
            // 
            this.AddFriend_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFriend_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddFriend_button.BackgroundImage = global::Chat.Properties.Resources.add;
            this.AddFriend_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddFriend_button.FlatAppearance.BorderSize = 0;
            this.AddFriend_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFriend_button.Location = new System.Drawing.Point(329, 3);
            this.AddFriend_button.Margin = new System.Windows.Forms.Padding(0);
            this.AddFriend_button.Name = "AddFriend_button";
            this.AddFriend_button.Size = new System.Drawing.Size(25, 25);
            this.AddFriend_button.TabIndex = 9;
            this.AddFriend_button.UseVisualStyleBackColor = false;
            // 
            // MoreInfo_button
            // 
            this.MoreInfo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreInfo_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MoreInfo_button.BackgroundImage = global::Chat.Properties.Resources.消息;
            this.MoreInfo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoreInfo_button.FlatAppearance.BorderSize = 0;
            this.MoreInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoreInfo_button.Location = new System.Drawing.Point(363, 3);
            this.MoreInfo_button.Margin = new System.Windows.Forms.Padding(0);
            this.MoreInfo_button.Name = "MoreInfo_button";
            this.MoreInfo_button.Size = new System.Drawing.Size(25, 25);
            this.MoreInfo_button.TabIndex = 8;
            this.MoreInfo_button.UseVisualStyleBackColor = false;
            // 
            // Signature_label
            // 
            this.Signature_label.AutoSize = true;
            this.Signature_label.Location = new System.Drawing.Point(75, 39);
            this.Signature_label.Name = "Signature_label";
            this.Signature_label.Size = new System.Drawing.Size(0, 12);
            this.Signature_label.TabIndex = 7;
            // 
            // NickName_label
            // 
            this.NickName_label.AutoSize = true;
            this.NickName_label.Location = new System.Drawing.Point(75, 9);
            this.NickName_label.Name = "NickName_label";
            this.NickName_label.Size = new System.Drawing.Size(0, 12);
            this.NickName_label.TabIndex = 6;
            // 
            // UserHeadImg_panel
            // 
            this.UserHeadImg_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserHeadImg_panel.Location = new System.Drawing.Point(3, 3);
            this.UserHeadImg_panel.Name = "UserHeadImg_panel";
            this.UserHeadImg_panel.Size = new System.Drawing.Size(55, 55);
            this.UserHeadImg_panel.TabIndex = 5;
            // 
            // SearchFriendListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "SearchFriendListItem";
            this.Size = new System.Drawing.Size(392, 69);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddFriend_button;
        private System.Windows.Forms.Button MoreInfo_button;
        private System.Windows.Forms.Label Signature_label;
        private System.Windows.Forms.Label NickName_label;
        private System.Windows.Forms.Panel UserHeadImg_panel;

    }
}
