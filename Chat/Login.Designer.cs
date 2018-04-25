namespace Chat
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_button = new System.Windows.Forms.Button();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.Account_textBox = new System.Windows.Forms.TextBox();
            this.ForgetPass_label = new System.Windows.Forms.Label();
            this.Register_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RememberPass_checkBox = new System.Windows.Forms.CheckBox();
            this.AutoLogin_checkBox = new System.Windows.Forms.CheckBox();
            this.UserHeadImg_panel = new System.Windows.Forms.Panel();
            this.HisAccount_combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorMsg_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(180, 206);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "登陆";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(70, 134);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '*';
            this.Pass_textBox.Size = new System.Drawing.Size(187, 21);
            this.Pass_textBox.TabIndex = 1;
            this.Pass_textBox.Enter += new System.EventHandler(this.Pass_textBox_Enter);
            this.Pass_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pass_textBox_KeyPress);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.ForeColor = System.Drawing.Color.White;
            this.Close_button.Location = new System.Drawing.Point(261, 206);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 3;
            this.Close_button.Text = "关闭";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Account_textBox
            // 
            this.Account_textBox.BackColor = System.Drawing.Color.White;
            this.Account_textBox.Location = new System.Drawing.Point(70, 97);
            this.Account_textBox.Name = "Account_textBox";
            this.Account_textBox.Size = new System.Drawing.Size(187, 21);
            this.Account_textBox.TabIndex = 0;
            this.Account_textBox.Tag = "";
            this.Account_textBox.Enter += new System.EventHandler(this.Account_textBox_Enter);
            this.Account_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Account_textBox_KeyPress);
            this.Account_textBox.Leave += new System.EventHandler(this.Account_textBox_Leave);
            // 
            // ForgetPass_label
            // 
            this.ForgetPass_label.AutoSize = true;
            this.ForgetPass_label.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPass_label.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForgetPass_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ForgetPass_label.Location = new System.Drawing.Point(276, 100);
            this.ForgetPass_label.Name = "ForgetPass_label";
            this.ForgetPass_label.Size = new System.Drawing.Size(49, 11);
            this.ForgetPass_label.TabIndex = 5;
            this.ForgetPass_label.Text = "忘记密码";
            this.ForgetPass_label.Click += new System.EventHandler(this.ForgetPass_label_Click);
            // 
            // Register_label
            // 
            this.Register_label.AutoSize = true;
            this.Register_label.BackColor = System.Drawing.Color.Transparent;
            this.Register_label.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.Register_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Register_label.Location = new System.Drawing.Point(276, 137);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(49, 11);
            this.Register_label.TabIndex = 6;
            this.Register_label.Text = "申请账号";
            this.Register_label.Click += new System.EventHandler(this.Register_label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "账号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "密码";
            // 
            // RememberPass_checkBox
            // 
            this.RememberPass_checkBox.AutoSize = true;
            this.RememberPass_checkBox.Location = new System.Drawing.Point(70, 175);
            this.RememberPass_checkBox.Name = "RememberPass_checkBox";
            this.RememberPass_checkBox.Size = new System.Drawing.Size(72, 16);
            this.RememberPass_checkBox.TabIndex = 9;
            this.RememberPass_checkBox.Text = "记住密码";
            this.RememberPass_checkBox.UseVisualStyleBackColor = true;
            this.RememberPass_checkBox.CheckedChanged += new System.EventHandler(this.RememberPass_checkBox_CheckedChanged);
            // 
            // AutoLogin_checkBox
            // 
            this.AutoLogin_checkBox.AutoSize = true;
            this.AutoLogin_checkBox.BackColor = System.Drawing.Color.White;
            this.AutoLogin_checkBox.Location = new System.Drawing.Point(185, 175);
            this.AutoLogin_checkBox.Name = "AutoLogin_checkBox";
            this.AutoLogin_checkBox.Size = new System.Drawing.Size(72, 16);
            this.AutoLogin_checkBox.TabIndex = 10;
            this.AutoLogin_checkBox.Text = "自动登录";
            this.AutoLogin_checkBox.UseVisualStyleBackColor = false;
            this.AutoLogin_checkBox.CheckedChanged += new System.EventHandler(this.AutoLogin_checkBox_CheckedChanged);
            // 
            // UserHeadImg_panel
            // 
            this.UserHeadImg_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserHeadImg_panel.Location = new System.Drawing.Point(135, 6);
            this.UserHeadImg_panel.Name = "UserHeadImg_panel";
            this.UserHeadImg_panel.Size = new System.Drawing.Size(85, 85);
            this.UserHeadImg_panel.TabIndex = 11;
            // 
            // HisAccount_combox
            // 
            this.HisAccount_combox.FormattingEnabled = true;
            this.HisAccount_combox.Location = new System.Drawing.Point(70, 209);
            this.HisAccount_combox.Name = "HisAccount_combox";
            this.HisAccount_combox.Size = new System.Drawing.Size(72, 20);
            this.HisAccount_combox.TabIndex = 12;
            this.HisAccount_combox.Visible = false;
            this.HisAccount_combox.SelectedIndexChanged += new System.EventHandler(this.HisAccount_combox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "快捷";
            this.label1.Visible = false;
            // 
            // ErrorMsg_label
            // 
            this.ErrorMsg_label.AutoSize = true;
            this.ErrorMsg_label.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsg_label.Location = new System.Drawing.Point(278, 175);
            this.ErrorMsg_label.Name = "ErrorMsg_label";
            this.ErrorMsg_label.Size = new System.Drawing.Size(0, 12);
            this.ErrorMsg_label.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 241);
            this.Controls.Add(this.ErrorMsg_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HisAccount_combox);
            this.Controls.Add(this.UserHeadImg_panel);
            this.Controls.Add(this.AutoLogin_checkBox);
            this.Controls.Add(this.RememberPass_checkBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Register_label);
            this.Controls.Add(this.ForgetPass_label);
            this.Controls.Add(this.Account_textBox);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Pass_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.TextBox Account_textBox;
        private System.Windows.Forms.Label ForgetPass_label;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox RememberPass_checkBox;
        private System.Windows.Forms.CheckBox AutoLogin_checkBox;
        private System.Windows.Forms.Panel UserHeadImg_panel;
        private System.Windows.Forms.ComboBox HisAccount_combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorMsg_label;

    }
}

