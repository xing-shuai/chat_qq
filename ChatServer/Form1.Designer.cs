namespace ChatServer
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartServer_button = new System.Windows.Forms.Button();
            this.CloseServer_button = new System.Windows.Forms.Button();
            this.Info_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartServer_button
            // 
            this.StartServer_button.Location = new System.Drawing.Point(11, 12);
            this.StartServer_button.Name = "StartServer_button";
            this.StartServer_button.Size = new System.Drawing.Size(75, 23);
            this.StartServer_button.TabIndex = 0;
            this.StartServer_button.Text = "启动服务";
            this.StartServer_button.UseVisualStyleBackColor = true;
            this.StartServer_button.Click += new System.EventHandler(this.StartServer_button_Click);
            // 
            // CloseServer_button
            // 
            this.CloseServer_button.Location = new System.Drawing.Point(125, 12);
            this.CloseServer_button.Name = "CloseServer_button";
            this.CloseServer_button.Size = new System.Drawing.Size(75, 23);
            this.CloseServer_button.TabIndex = 1;
            this.CloseServer_button.Text = "关闭服务";
            this.CloseServer_button.UseVisualStyleBackColor = true;
            this.CloseServer_button.Click += new System.EventHandler(this.CloseServer_button_Click);
            // 
            // Info_textBox
            // 
            this.Info_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_textBox.Location = new System.Drawing.Point(11, 41);
            this.Info_textBox.Multiline = true;
            this.Info_textBox.Name = "Info_textBox";
            this.Info_textBox.Size = new System.Drawing.Size(502, 280);
            this.Info_textBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 333);
            this.Controls.Add(this.Info_textBox);
            this.Controls.Add(this.CloseServer_button);
            this.Controls.Add(this.StartServer_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServer_button;
        private System.Windows.Forms.Button CloseServer_button;
        private System.Windows.Forms.TextBox Info_textBox;
    }
}

