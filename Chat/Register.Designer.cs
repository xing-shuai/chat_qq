namespace Chat
{
    partial class Register
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.Signature = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boStar = new System.Windows.Forms.ComboBox();
            this.BloodType = new System.Windows.Forms.ComboBox();
            this.RealName = new System.Windows.Forms.TextBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPwdAgain = new System.Windows.Forms.TextBox();
            this.LoginPwd = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Panel();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.NickName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblLoginPwdAgain = new System.Windows.Forms.Label();
            this.lblLoginPwd = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.grpBaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            this.Sex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(242, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegist.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegist.ForeColor = System.Drawing.Color.White;
            this.btnRegist.Location = new System.Drawing.Point(173, 352);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(63, 23);
            this.btnRegist.TabIndex = 17;
            this.btnRegist.Text = "注册";
            this.btnRegist.UseVisualStyleBackColor = false;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.ForeColor = System.Drawing.Color.Red;
            this.Error_label.Location = new System.Drawing.Point(97, 357);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(0, 12);
            this.Error_label.TabIndex = 19;
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpDetails.Controls.Add(this.Signature);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.boStar);
            this.grpDetails.Controls.Add(this.BloodType);
            this.grpDetails.Controls.Add(this.RealName);
            this.grpDetails.Controls.Add(this.lblBloodType);
            this.grpDetails.Controls.Add(this.lblStar);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Location = new System.Drawing.Point(21, 216);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(285, 130);
            this.grpDetails.TabIndex = 22;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "选填信息";
            // 
            // Signature
            // 
            this.Signature.Location = new System.Drawing.Point(82, 16);
            this.Signature.Name = "Signature";
            this.Signature.Size = new System.Drawing.Size(154, 21);
            this.Signature.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "签名";
            // 
            // boStar
            // 
            this.boStar.FormattingEnabled = true;
            this.boStar.Items.AddRange(new object[] {
            "水瓶座（01/20-02/18）",
            "双鱼座（02/19-03/20）",
            "白羊座（03/21-04/19）",
            "金牛座（04/20-05/20）",
            "双子座（05/21-06/21）",
            "巨蟹座（06/22-07/22）",
            "狮子座（07/23-08/22）",
            "处女座（08/23-09/22）",
            "天秤座（09/23-10/23）",
            "天蝎座（10/24-11/22）",
            "射手座（11/23-12/21）",
            "魔羯座（12/22-01/19）"});
            this.boStar.Location = new System.Drawing.Point(82, 72);
            this.boStar.Name = "boStar";
            this.boStar.Size = new System.Drawing.Size(154, 20);
            this.boStar.TabIndex = 23;
            // 
            // BloodType
            // 
            this.BloodType.FormattingEnabled = true;
            this.BloodType.Items.AddRange(new object[] {
            "O型",
            "A型",
            "B型",
            "AB型"});
            this.BloodType.Location = new System.Drawing.Point(82, 100);
            this.BloodType.Name = "BloodType";
            this.BloodType.Size = new System.Drawing.Size(154, 20);
            this.BloodType.TabIndex = 7;
            // 
            // RealName
            // 
            this.RealName.Location = new System.Drawing.Point(82, 43);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(154, 21);
            this.RealName.TabIndex = 3;
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(47, 103);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(29, 12);
            this.lblBloodType.TabIndex = 2;
            this.lblBloodType.Text = "血型";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(47, 75);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(29, 12);
            this.lblStar.TabIndex = 1;
            this.lblStar.Text = "星座";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "真实姓名";
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.Age);
            this.grpBaseInfo.Controls.Add(this.Email);
            this.grpBaseInfo.Controls.Add(this.label1);
            this.grpBaseInfo.Controls.Add(this.LoginPwdAgain);
            this.grpBaseInfo.Controls.Add(this.LoginPwd);
            this.grpBaseInfo.Controls.Add(this.Sex);
            this.grpBaseInfo.Controls.Add(this.NickName);
            this.grpBaseInfo.Controls.Add(this.lblAge);
            this.grpBaseInfo.Controls.Add(this.lblLoginPwdAgain);
            this.grpBaseInfo.Controls.Add(this.lblLoginPwd);
            this.grpBaseInfo.Controls.Add(this.lblSex);
            this.grpBaseInfo.Controls.Add(this.lblNickName);
            this.grpBaseInfo.Location = new System.Drawing.Point(21, 11);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Size = new System.Drawing.Size(285, 199);
            this.grpBaseInfo.TabIndex = 21;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "基本信息";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(82, 54);
            this.Age.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(66, 21);
            this.Age.TabIndex = 12;
            this.Age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(82, 172);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '*';
            this.Email.Size = new System.Drawing.Size(154, 21);
            this.Email.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "邮箱";
            // 
            // LoginPwdAgain
            // 
            this.LoginPwdAgain.Location = new System.Drawing.Point(82, 143);
            this.LoginPwdAgain.Name = "LoginPwdAgain";
            this.LoginPwdAgain.PasswordChar = '*';
            this.LoginPwdAgain.Size = new System.Drawing.Size(154, 21);
            this.LoginPwdAgain.TabIndex = 9;
            // 
            // LoginPwd
            // 
            this.LoginPwd.Location = new System.Drawing.Point(82, 115);
            this.LoginPwd.Name = "LoginPwd";
            this.LoginPwd.PasswordChar = '*';
            this.LoginPwd.Size = new System.Drawing.Size(154, 21);
            this.LoginPwd.TabIndex = 8;
            // 
            // Sex
            // 
            this.Sex.Controls.Add(this.Female);
            this.Sex.Controls.Add(this.Male);
            this.Sex.Location = new System.Drawing.Point(82, 81);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(154, 24);
            this.Sex.TabIndex = 7;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(55, 5);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(35, 16);
            this.Female.TabIndex = 1;
            this.Female.Text = "女";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Checked = true;
            this.Male.Location = new System.Drawing.Point(4, 4);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(35, 16);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "男";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(82, 26);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(154, 21);
            this.NickName.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(47, 60);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 12);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "年龄";
            // 
            // lblLoginPwdAgain
            // 
            this.lblLoginPwdAgain.AutoSize = true;
            this.lblLoginPwdAgain.Location = new System.Drawing.Point(23, 147);
            this.lblLoginPwdAgain.Name = "lblLoginPwdAgain";
            this.lblLoginPwdAgain.Size = new System.Drawing.Size(53, 12);
            this.lblLoginPwdAgain.TabIndex = 3;
            this.lblLoginPwdAgain.Text = "确认密码";
            // 
            // lblLoginPwd
            // 
            this.lblLoginPwd.AutoSize = true;
            this.lblLoginPwd.Location = new System.Drawing.Point(47, 119);
            this.lblLoginPwd.Name = "lblLoginPwd";
            this.lblLoginPwd.Size = new System.Drawing.Size(29, 12);
            this.lblLoginPwd.TabIndex = 2;
            this.lblLoginPwd.Text = "密码";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(47, 87);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(29, 12);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "性别";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(47, 30);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(29, 12);
            this.lblNickName.TabIndex = 0;
            this.lblNickName.Text = "昵称";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 387);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpBaseInfo);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "注册";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            this.Sex.ResumeLayout(false);
            this.Sex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ComboBox BloodType;
        private System.Windows.Forms.TextBox RealName;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginPwdAgain;
        private System.Windows.Forms.TextBox LoginPwd;
        private System.Windows.Forms.Panel Sex;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblLoginPwdAgain;
        private System.Windows.Forms.Label lblLoginPwd;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.ComboBox boStar;
        private System.Windows.Forms.TextBox Signature;
        private System.Windows.Forms.Label label2;


    }
}