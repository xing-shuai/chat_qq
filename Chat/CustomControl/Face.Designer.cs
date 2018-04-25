namespace Chat.CustomControl
{
    partial class Face
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
            this.PreView_pictureBox = new System.Windows.Forms.PictureBox();
            this.Face_groupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreView_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreView_pictureBox
            // 
            this.PreView_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreView_pictureBox.BackColor = System.Drawing.Color.White;
            this.PreView_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreView_pictureBox.Location = new System.Drawing.Point(399, 21);
            this.PreView_pictureBox.Name = "PreView_pictureBox";
            this.PreView_pictureBox.Size = new System.Drawing.Size(26, 26);
            this.PreView_pictureBox.TabIndex = 4;
            this.PreView_pictureBox.TabStop = false;
            this.PreView_pictureBox.Visible = false;
            // 
            // Face_groupBox
            // 
            this.Face_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Face_groupBox.Location = new System.Drawing.Point(7, 3);
            this.Face_groupBox.Name = "Face_groupBox";
            this.Face_groupBox.Size = new System.Drawing.Size(423, 139);
            this.Face_groupBox.TabIndex = 3;
            this.Face_groupBox.TabStop = false;
            // 
            // Face
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PreView_pictureBox);
            this.Controls.Add(this.Face_groupBox);
            this.Name = "Face";
            this.Size = new System.Drawing.Size(437, 150);
            ((System.ComponentModel.ISupportInitialize)(this.PreView_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PreView_pictureBox;
        private System.Windows.Forms.GroupBox Face_groupBox;

    }
}
