namespace Chat
{
    partial class AddChatRoom
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
            this.ChatRoomName_textBox = new System.Windows.Forms.TextBox();
            this.ChatRoomRemarks_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Friends_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ChatRoomName_textBox
            // 
            this.ChatRoomName_textBox.Location = new System.Drawing.Point(83, 12);
            this.ChatRoomName_textBox.Name = "ChatRoomName_textBox";
            this.ChatRoomName_textBox.Size = new System.Drawing.Size(296, 21);
            this.ChatRoomName_textBox.TabIndex = 0;
            this.ChatRoomName_textBox.MouseEnter += new System.EventHandler(this.ChatRoomName_textBox_MouseEnter);
            // 
            // ChatRoomRemarks_textBox
            // 
            this.ChatRoomRemarks_textBox.Location = new System.Drawing.Point(83, 50);
            this.ChatRoomRemarks_textBox.Multiline = true;
            this.ChatRoomRemarks_textBox.Name = "ChatRoomRemarks_textBox";
            this.ChatRoomRemarks_textBox.Size = new System.Drawing.Size(296, 80);
            this.ChatRoomRemarks_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "描述";
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.ForeColor = System.Drawing.Color.White;
            this.Close_button.Location = new System.Drawing.Point(338, 380);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 8;
            this.Close_button.Text = "关闭";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_button.ForeColor = System.Drawing.Color.White;
            this.Add_button.Location = new System.Drawing.Point(257, 380);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "创建";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.ForeColor = System.Drawing.Color.Red;
            this.Error_label.Location = new System.Drawing.Point(169, 200);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(0, 12);
            this.Error_label.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "选择好友";
            // 
            // Friends_listBox
            // 
            this.Friends_listBox.FormattingEnabled = true;
            this.Friends_listBox.ItemHeight = 12;
            this.Friends_listBox.Location = new System.Drawing.Point(83, 145);
            this.Friends_listBox.Name = "Friends_listBox";
            this.Friends_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Friends_listBox.Size = new System.Drawing.Size(296, 220);
            this.Friends_listBox.TabIndex = 11;
            // 
            // AddChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 405);
            this.Controls.Add(this.Friends_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChatRoomRemarks_textBox);
            this.Controls.Add(this.ChatRoomName_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddChatRoom";
            this.Text = "创建聊天室";
            this.Load += new System.EventHandler(this.AddChatRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatRoomName_textBox;
        private System.Windows.Forms.TextBox ChatRoomRemarks_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Friends_listBox;
    }
}