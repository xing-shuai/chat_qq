using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary.JSON;
using Chat.Entity;
using Chat.Public;

namespace Chat.CustomControl
{
    public partial class SearchFriendListItem : UserControl
    {
        public SearchFriendListItem()
        {
            InitializeComponent();
        }

        public bool isAddButtonVisible = true;

        public void Init(JsonData data)
        {
            AddFriend_button.Click += new EventHandler(AddFriend);
            AddFriend_button.Visible = isAddButtonVisible;
            MoreInfo_button.Click += new EventHandler(MoreInfo);
            this.AccountData = data;
            try
            {
                UserHeadImg_panel.BackgroundImage = Image.FromFile(@"Resources\img\" + data["UserHeadImg"].ToString());
            }
            catch { }
            NickName_label.Text = data["NickName"].ToString();
            Signature_label.Text = data["Signature"].ToString();
        }

        /// <summary>
        /// 查看对方详情信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreInfo(object sender, EventArgs e)
        {
            DisplayUserInfo disUserInfo = new DisplayUserInfo(AccountData);
            if (isAddButtonVisible)
            {
                disUserInfo.Me = Me;
                disUserInfo.Socket = Socket;
            }
            else
            {
                disUserInfo.isAddButtonVisible = false;
            }
            disUserInfo.Show();
        }

        /// <summary>
        /// 通知对方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFriend(object sender, EventArgs e)
        {
            //SearchFriends search = this.Owner as SearchFriends;

            //Panel panel = ((this.Owner.Controls["tabControl1"] as TabControl).TabPages[0].Controls["Panel1"] as Panel);

            //panel.BackColor = Color.Red;
            //panel.Width = 100;
            //panel.Height = 50;
            //panel.Location = new Point(Cursor.Position.X - search.Location.X - 50, Cursor.Position.Y - search.Location.Y - 10);

            Notification notification = new Notification(PublicTool.GetAppConfig("mySqlConn"));
            JsonData insertData = new JsonData();
            string toUser = AccountData["Account"].ToString();
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

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public JsonData AccountData { get; set; }

        public System.Net.Sockets.Socket Socket { get; set; }

        public string Me { get; set; }

        public SearchFriends Owner { get; set; }
    }
}
