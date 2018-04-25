namespace Chat
{
    partial class NotificationShow
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
            this.Refuse_button = new System.Windows.Forms.Button();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Refuse_button
            // 
            this.Refuse_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Refuse_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Refuse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refuse_button.ForeColor = System.Drawing.Color.White;
            this.Refuse_button.Location = new System.Drawing.Point(317, 112);
            this.Refuse_button.Name = "Refuse_button";
            this.Refuse_button.Size = new System.Drawing.Size(75, 23);
            this.Refuse_button.TabIndex = 10;
            this.Refuse_button.Text = "拒绝";
            this.Refuse_button.UseVisualStyleBackColor = false;
            this.Refuse_button.Click += new System.EventHandler(this.Refuse_button_Click);
            // 
            // Confirm_button
            // 
            this.Confirm_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_button.ForeColor = System.Drawing.Color.White;
            this.Confirm_button.Location = new System.Drawing.Point(236, 112);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(75, 23);
            this.Confirm_button.TabIndex = 9;
            this.Confirm_button.Text = "同意";
            this.Confirm_button.UseVisualStyleBackColor = false;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Chat.Properties.Resources.询问;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 75);
            this.panel1.TabIndex = 12;
            // 
            // NotificationShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 136);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refuse_button);
            this.Controls.Add(this.Confirm_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationShow";
            this.Text = "通知消息";
            this.Load += new System.EventHandler(this.NotificationShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refuse_button;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}