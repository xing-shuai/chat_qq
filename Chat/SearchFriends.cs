using Chat.CustomControl;
using Chat.Entity;
using Chat.Public;
using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class SearchFriends : Form
    {
        public SearchFriends()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            if (searchText == "")
            {
                return;
            }
            if (e.KeyChar == 13)
            {
                SearchRes_panel.Controls.Clear();
                UserInfo user = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
                JsonData data = user.ExecuteSimpleQuery("Account ='" + searchText + "' or NickName like '%" + searchText + "%'");
                Socket socket = (this.Owner as FriendsList).socketClient;
                Friend friend = new Friend(PublicTool.GetAppConfig("mySqlConn"));
                foreach (JsonData ob in data)
                {
                    SearchFriendListItem item = new SearchFriendListItem();
                    int isFriend = friend.ExecuteSimpleQuery("Account='" + ob["Account"] + "' and FriendAccount='" + Me + "'").Count;
                    if (isFriend > 0)
                    {
                        item.isAddButtonVisible = false;
                    }
                    else
                    {
                        item.Socket = socket;
                        item.Me = Me;
                    }
                    item.Owner = this;
                    item.Width = SearchRes_panel.Width;
                    item.Init(ob);
                    item.Dock = DockStyle.Top;
                    SearchRes_panel.Controls.Add(item);
                }
            }
        }


        public string Me { get; set; }

        private void SearchRes_panel_MouseMove(object sender, MouseEventArgs e)
        {
            //label2.Text = Cursor.Position.X.ToString() + ":" + Cursor.Position.Y.ToString() + "    " + this.Location.X.ToString() + ":" + this.Location.Y.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
