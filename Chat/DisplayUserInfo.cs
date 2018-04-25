using Chat.Entity;
using Chat.Public;
using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class DisplayUserInfo : Form
    {
        public DisplayUserInfo(JsonData info)
        {
            this.UserInfo = info;
            InitializeComponent();
        }
        public bool isAddButtonVisible = true;
        public JsonData UserInfo { get; set; }

        private void DisplayUserInfo_Load(object sender, EventArgs e)
        {
            button1.Visible = isAddButtonVisible;
            Account_label.Text = UserInfo["Account"].ToString();
            NickName_label.Text = UserInfo["NickName"].ToString();
            Age_label.Text = UserInfo["Age"].ToString();
            Signature_label.Text = UserInfo["Signature"].ToString();
            RealName_label.Text = UserInfo["RealName"].ToString();
            BornStar_label.Text = UserInfo["BornStar"].ToString();
            BloodType_label.Text = UserInfo["BloodType"].ToString();
            Email_label.Text = UserInfo["Email"].ToString();
            try
            {
                UserImage_panel.BackgroundImage = Image.FromFile(@"Resources\img\" + UserInfo["UserHeadImg"].ToString());
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(PublicTool.GetAppConfig("mySqlConn"));
            JsonData insertData = new JsonData();
            string toUser = UserInfo["Account"].ToString();
            insertData["ID"] = Guid.NewGuid().ToString();
            insertData["Type"] = "0";
            insertData["Content"] = Me + "请求加您为好友";
            insertData["Time"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            insertData["FromUser"] = Me;
            insertData["ToUser"] = toUser;
            if (notification.Add(insertData))
            {
                byte[] arrClientMsg = Encoding.UTF8.GetBytes("5#" + Me + "#" + toUser);
                byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                sendMessage[0] = 0;
                Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                this.Socket.Send(sendMessage);
                MessageBox.Show("已向" + toUser + "发送好友请求");
            }
        }

        public string Me { get; set; }
        public System.Net.Sockets.Socket Socket { get; set; }
    }
}
