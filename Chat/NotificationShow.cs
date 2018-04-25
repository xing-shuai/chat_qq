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
    public partial class NotificationShow : Form
    {
        private string fromUser;
        private string chatRoomID;
        private string type;

        public NotificationShow()
        {
            InitializeComponent();
        }

        public NotificationShow(string fromUser, string chatRoomIDOrme, string type)
        {
            this.fromUser = fromUser;
            if (type == "1")
            {
                this.chatRoomID = chatRoomIDOrme;
            }
            else if (type == "0")
            {
                this.Me = chatRoomIDOrme;
            }
            this.type = type;
            InitializeComponent();
        }

        private void NotificationShow_Load(object sender, EventArgs e)
        {
            if (type == "1")//加群通知
            {
                Chatroom room = new Chatroom(PublicTool.GetAppConfig("mySqlConn"));
                JsonData res = room.ExecuteSimpleQuery("ID='" + chatRoomID + "'");
                if (res.Count > 0)
                {
                    label1.Text = this.fromUser + "邀请您加入聊天室【" + res[0]["Name"].ToString() + "】";
                }
            }
            else if (type == "0")//加好友通知
            {
                label1.Text = this.fromUser + "请求加您为好友";
            }
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if (type == "1")
            {
                ChatRoomMember chatRoomMember = new ChatRoomMember(PublicTool.GetAppConfig("mySqlConn"));
                JsonData chatRoomMemberData = new JsonData();
                chatRoomMemberData["ID"] = Guid.NewGuid().ToString();
                chatRoomMemberData["Member"] = fromUser;
                chatRoomMemberData["ChatRoomID"] = chatRoomID;
                chatRoomMemberData["AddTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                if (chatRoomMember.Add(chatRoomMemberData))
                {
                    panel1.BackgroundImage = Properties.Resources.验证成功;
                    FriendsList owner = this.Owner as FriendsList;
                    owner.InitChatRoomList();
                    Refuse_button.Enabled = false;
                }
            }
            else if (type == "0")
            {
                Friend friend = new Friend(PublicTool.GetAppConfig("mySqlConn"));
                JsonData friendData = new JsonData();

                Group group = new Group(PublicTool.GetAppConfig("mySqlConn"));
                JsonData myGroupData = group.ExecuteSimpleQuery("Owner='" + Me + "' order by CreateTime ASC");
                friendData["ID"] = Guid.NewGuid().ToString();
                friendData["Account"] = Me;
                friendData["FriendAccount"] = fromUser;
                friendData["GroupID"] = myGroupData[0]["ID"].ToString();
                friendData["AddTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                if (friend.Add(friendData))
                {
                    JsonData friendGroupData = group.ExecuteSimpleQuery("Owner='" + fromUser + "' order by CreateTime ASC");

                    friendData["ID"] = Guid.NewGuid().ToString();
                    friendData["Account"] = fromUser;
                    friendData["FriendAccount"] = Me;
                    friendData["GroupID"] = friendGroupData[0]["ID"].ToString();

                    friend.Add(friendData);

                    panel1.BackgroundImage = Properties.Resources.验证成功;
                    FriendsList owner = this.Owner as FriendsList;
                    owner.InitFriendsList();
                    Refuse_button.Enabled = false;

                    SessionList session = new SessionList(PublicTool.GetAppConfig("mySqlConn"));
                    JsonData sessionData = new JsonData();
                    sessionData["ID"] = Guid.NewGuid().ToString();
                    sessionData["Owner"] = Me;
                    sessionData["FriendAccount"] = fromUser;
                    sessionData["Message"] = "你们已经是好友啦，开始聊天吧";
                    sessionData["AddTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    session.Add(sessionData);

                    sessionData["ID"] = Guid.NewGuid().ToString();
                    sessionData["Owner"] = fromUser;
                    sessionData["FriendAccount"] = Me;
                    session.Add(sessionData);

                    FriendsList friendList = (this.Owner as FriendsList);
                    friendList.InitFriendsList();
                    friendList.InitHistoryChatList();

                    byte[] arrClientMsg = Encoding.UTF8.GetBytes("6#" + fromUser);
                    byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                    sendMessage[0] = 0;
                    Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                    friendList.socketClient.Send(sendMessage);
                }
            }
        }

        private void Refuse_button_Click(object sender, EventArgs e)
        {
            Confirm_button.Enabled = false;
            this.Close();
        }

        public string Me { get; set; }
    }
}
