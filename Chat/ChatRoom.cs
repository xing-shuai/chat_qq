using _CUSTOM_CONTROLS._ChatListBox;
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
    public partial class ChatRoom : Form
    {
        public ChatRoom(string chatRoomID)
        {
            InitializeComponent();
            this.chatRoomID = chatRoomID;
        }

        private string chatRoomID;

        private void ChatRoom_Load(object sender, EventArgs e)
        {
            ChatRoomMember roomMember = new ChatRoomMember(PublicTool.GetAppConfig("mySqlConn"));
            JsonData res = roomMember.ExecuteSimpleQuery("ChatRoomID='" + chatRoomID + "'");
            foreach (JsonData ob in res)
            {
                string account = ob["Member"].ToString();
                ChatListSubItem subItem = new ChatListSubItem(account, account, "", "", (ChatListSubItem.UserStatus)(int.Parse(ob["OnlineState"].ToString())), "");
                subItem.HeadImage = Image.FromFile(@"Resources\img\" + ob["UserHeadImg"].ToString());
                subItem.LastMsgTime = "";
                ChatRoomMember_ChatListView.Items.Add(subItem);
            }
        }

        private void ChatRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as FriendsList).dirChatRoom.Remove(chatRoomID);
        }
    }
}
