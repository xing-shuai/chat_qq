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
    public partial class AddChatRoom : Form
    {
        public AddChatRoom()
        {
            InitializeComponent();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string userID { get; set; }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string chatRoomName = ChatRoomName_textBox.Text.Trim();
            if (chatRoomName == "")
            {
                Error_label.Text = "聊天室名称不能为空";
                return;
            }
            Chatroom chatRoom = new Chatroom(PublicTool.GetAppConfig("mySqlConn"));
            JsonData data = new JsonData();
            string chatRoomID = Guid.NewGuid().ToString();
            data["ID"] = chatRoomID;
            data["Time"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            data["Remarks"] = ChatRoomRemarks_textBox.Text.Trim();
            data["Owner"] = userID;
            data["Name"] = chatRoomName;
            data["CoverImage"] = "room" + (int)new Random().Next(3) + ".png";
            if (chatRoom.Add(data))
            {
                string memberIDs = userID + "#";
                System.Windows.Forms.ListBox.SelectedObjectCollection selectItems = Friends_listBox.SelectedItems;
                Notification notification = new Notification(PublicTool.GetAppConfig("mySqlConn"));
                foreach (DataRowView row in selectItems)
                {
                    string friendAccount = row["FriendAccount"].ToString();
                    //将申请存入通知表 类型为1：加群通知
                    JsonData insertData = new JsonData();
                    insertData["ID"] = Guid.NewGuid().ToString();
                    insertData["Type"] = "1";
                    insertData["Content"] = userID + "邀请您加入聊天室" + chatRoomName;
                    insertData["Time"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    insertData["FromUser"] = userID;
                    insertData["ToUser"] = friendAccount;
                    if (notification.Add(insertData))
                    {
                        memberIDs += friendAccount + "#";
                    }
                }
                ChatRoomMember chatRoomMember = new ChatRoomMember(PublicTool.GetAppConfig("mySqlConn"));
                JsonData chatRoomMemberData = new JsonData();
                chatRoomMemberData["ID"] = Guid.NewGuid().ToString();
                chatRoomMemberData["Member"] = userID;
                chatRoomMemberData["ChatRoomID"] = chatRoomID;
                chatRoomMemberData["AddTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                if (chatRoomMember.Add(chatRoomMemberData))
                {
                    memberIDs += chatRoomID;
                    FriendsList owner = this.Owner as FriendsList;
                    byte[] arrClientMsg = Encoding.UTF8.GetBytes("4#" + memberIDs);
                    byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                    sendMessage[0] = 0;
                    Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                    owner.socketClient.Send(sendMessage);//通知服务器向在线好友加群发起申请
                    MessageBox.Show("聊天室创建成功");
                    owner.InitChatRoomList();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("聊天室创建失败");
            }
        }

        private void ChatRoomName_textBox_MouseEnter(object sender, EventArgs e)
        {
            Error_label.Text = "";
        }

        private void AddChatRoom_Load(object sender, EventArgs e)
        {
            Friend friend = new Friend(PublicTool.GetAppConfig("mySqlConn"));
            DataTable table = friend.ExecuteSimpleQueryWithTable("Account='" + userID + "'");
            Friends_listBox.DataSource = table;
            Friends_listBox.DisplayMember = "FriendAccount";
            Friends_listBox.ValueMember = "ID";
        }
    }
}
