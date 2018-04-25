using _CUSTOM_CONTROLS._ChatListBox;
using Chat.CustomControl;
using Chat.Entity;
using Chat.Public;
using ClassLibrary.DB;
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
    public partial class Login : Form
    {
        public ChatListSubItem me = new ChatListSubItem();

        private bool HisAccount_comboxSelectFlag = false;
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化历史账号和登陆信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists("account"))
            {
                string loginInfo = File.ReadAllText("account");
                if (loginInfo.Trim() == "")
                    return;
                string[] loginInfos = loginInfo.Split('#');
                List<ComboxItem> loginInfoList = new List<ComboxItem>();
                foreach (string _loginInfo in loginInfos)
                {
                    int subIndex = _loginInfo.IndexOf('$');
                    string account = _loginInfo.Substring(0, subIndex);
                    string accountInfo = _loginInfo.Substring(subIndex + 1, _loginInfo.Length - subIndex - 1);
                    if (PublicTool.GetAppConfig("lastAccount").ToString() == account)
                    {
                        Account_textBox.Text = account;
                        string[] accountDet = accountInfo.Split('$');
                        if (accountDet[0] == "1")
                        {
                            Pass_textBox.Text = accountDet[2];
                            RememberPass_checkBox.Checked = true;
                        }
                        if (accountDet[1] == "1")
                        {
                            AutoLogin_checkBox.Checked = true;
                        }
                        UserHeadImg_panel.BackgroundImage = Image.FromFile(@"Resources\img\" + accountDet[3]);
                    }
                    loginInfoList.Add(new ComboxItem(account, accountInfo));
                }
                HisAccount_combox.DataSource = loginInfoList;
                if (loginInfoList.Count > 1)
                {
                    HisAccount_combox.Visible = true;
                    label1.Visible = true;
                }
            }
            else
            {
                File.Create("account").Dispose();
            }
        }

        /// <summary>
        /// 是否直接关闭
        /// </summary>
        public bool isClose;

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.isClose = true;
        }

        /// <summary>
        ///登陆 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_button_Click(object sender, EventArgs e)
        {
            string account = Account_textBox.Text.Trim();
            string pass = Pass_textBox.Text;
            UserInfo user = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
            JsonData res = user.ExecuteSimpleQuery("Account='" + account + "'");
            if (res.Count == 0)
            {
                ErrorMsg_label.Text = "账户不存在";
                return;
            }
            if (res[0]["Pass"].ToString().Trim() != pass)
            {
                ErrorMsg_label.Text = "密码错误";
                return;
            }

            string userHead = res[0]["UserHeadImg"].ToString();
            SaveAccountLoginInfo(account, pass, userHead);
            PublicTool.UpdateAppConfig("lastAccount", account);
            me.ID = account;
            me.Signature = res[0]["Signature"].ToString();
            me.HeadImage = UserHeadImg_panel.BackgroundImage;
            me.NicName = res[0]["NickName"].ToString();
            this.Close();
        }

        /// <summary>
        /// 历史账号选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HisAccount_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HisAccount_comboxSelectFlag)
            {
                ComboxItem accountInfo = (ComboxItem)HisAccount_combox.SelectedItem;
                Account_textBox.Text = accountInfo.Text;
                string[] accountDet = accountInfo.Value.Split('$');
                if (accountDet[0] == "1")
                {
                    Pass_textBox.Text = accountDet[2];
                    RememberPass_checkBox.Checked = true;
                }
                else
                {
                    Pass_textBox.Text = "";
                    RememberPass_checkBox.Checked = false;
                }
                if (accountDet[1] == "1")
                    AutoLogin_checkBox.Checked = true;
                else
                    AutoLogin_checkBox.Checked = false;
                UserHeadImg_panel.BackgroundImage = Image.FromFile(@"Resources\img\" + accountDet[3]);
            }
            HisAccount_comboxSelectFlag = true;
        }

        /// <summary>
        /// 自动登录选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoLogin_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoLogin_checkBox.Checked)
            {
                RememberPass_checkBox.Checked = true;
            }
        }

        /// <summary>
        /// 保存登录信息
        /// </summary>
        private void SaveAccountLoginInfo(string loginAccount, string loginPass, string loginUserHead)
        {
            List<ComboxItem> list = (List<ComboxItem>)HisAccount_combox.DataSource;
            if (list == null)
            {
                list = new List<ComboxItem>();
                list.Add(new ComboxItem(loginAccount, (RememberPass_checkBox.Checked ? "1" : "0") + "$" + (AutoLogin_checkBox.Checked ? "1" : "0") + "$" + (RememberPass_checkBox.Checked ? loginPass : "") + "$" + loginUserHead));
            }
            else
            {
                bool flag = true;
                foreach (ComboxItem item in list)
                {
                    if (item.Text == loginAccount)
                    {
                        flag = false;
                        list.Remove(item);
                        list.Add(new ComboxItem(loginAccount, (RememberPass_checkBox.Checked ? "1" : "0") + "$" + (AutoLogin_checkBox.Checked ? "1" : "0") + "$" + (RememberPass_checkBox.Checked ? loginPass : "") + "$" + loginUserHead));
                        break;
                    }
                }
                if (flag)
                {
                    list.Add(new ComboxItem(loginAccount, (RememberPass_checkBox.Checked ? "1" : "0") + "$" + (AutoLogin_checkBox.Checked ? "1" : "0") + "$" + (RememberPass_checkBox.Checked ? loginPass : "") + "$" + loginUserHead));
                }
            }
            string info = String.Empty;
            foreach (ComboxItem item in list)
            {
                info += item.Text + "$" + item.Value + "#";
            }
            info = info.Substring(0, info.Length - 1);
            try
            {
                File.WriteAllText("account", info);
            }
            catch
            {
            }
        }


        /// <summary>
        /// 申请账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_label_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }


        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForgetPass_label_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 账户输入框回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Account_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Account_textBox.Text.Trim() == "")
                    return;
                if (Pass_textBox.Text.Trim() == "")
                {
                    Pass_textBox.Focus();
                }
                else
                {
                    this.Login_button_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// 密码输入框回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pass_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Pass_textBox.Text.Trim() == "")
                    return;
                this.Login_button_Click(sender, e);
            }
        }

        private void Account_textBox_Enter(object sender, EventArgs e)
        {
            ErrorMsg_label.Text = "";
        }

        private void Pass_textBox_Enter(object sender, EventArgs e)
        {
            ErrorMsg_label.Text = "";
        }

        private void Account_textBox_Leave(object sender, EventArgs e)
        {
            string account = Account_textBox.Text.Trim();
            if (account == "")
                return;
            UserInfo user = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
            JsonData res = user.ExecuteSimpleQuery("Account='" + account + "'");
            if (res.Count > 0)
            {
                try
                {
                    UserHeadImg_panel.BackgroundImage = Image.FromFile(@"Resources\img\" + res[0]["UserHeadImg"].ToString());
                }
                catch { }
            }
            else
            {
                UserHeadImg_panel.BackgroundImage = null;
            }
        }

        /// <summary>
        /// 记住密码未选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RememberPass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!RememberPass_checkBox.Checked)
            {
                AutoLogin_checkBox.Checked = false;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.isClose = true;
        }
    }
}
