using Chat.Entity;
using Chat.Public;
using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            string nickName = NickName.Text.Trim();
            if (nickName == "")
            {
                Error_label.Text = "用户名为空";
                return;
            }

            UserInfo user = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
            if (user.Exist("Account='" + nickName + "'"))
            {
                Error_label.Text = "用户名已存在";
                return;
            }

            int age = (int)Age.Value;
            if (age > 100)
            {
                Error_label.Text = "年龄不合法";
                return;
            }
            string sex = (Male.Checked == true ? "0" : "1");
            string pass = LoginPwd.Text;
            if (pass == "")
            {
                Error_label.Text = "密码为空";
                return;
            }
            string confirmPass = LoginPwdAgain.Text;
            if (pass != confirmPass)
            {
                Error_label.Text = "两次密码不一致";
                return;
            }
            string email = Email.Text.Trim();
            if (email == "")
            {
                Error_label.Text = "邮箱为空";
                return;
            }
            JsonData insertData = new JsonData();
            insertData["Account"] = nickName;
            insertData["Pass"] = pass;
            insertData["NickName"] = nickName;
            insertData["Age"] = age;
            insertData["Sex"] = sex;
            insertData["Email"] = email;

            string realName = RealName.Text.Trim();
            string bStar = (string)boStar.SelectedValue;
            string bloodType = (string)BloodType.SelectedValue;
            string signature = Signature.Text;


            insertData["RealName"] = realName;
            insertData["BornStar"] = bStar;
            insertData["Signature"] = signature;
            insertData["BloodType"] = bloodType;

            if (user.Add(insertData))
            {
                Group group = new Group(PublicTool.GetAppConfig("mySqlConn"));
                JsonData groupData = new JsonData();
                groupData["ID"] = Guid.NewGuid().ToString();
                groupData["GroupName"] = "我的好友";
                groupData["CreateTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                groupData["Owner"] = nickName;
                if (group.Add(groupData))
                    MessageBox.Show("注册成功");
                else
                    Error_label.Text = "注册失败";
            }
            else
            {
                Error_label.Text = "注册失败";
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
