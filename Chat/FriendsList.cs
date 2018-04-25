using _CUSTOM_CONTROLS._ChatListBox;
using Chat.CustomControl;
using Chat.Entity;
using Chat.Public;
using MyClassLibrary.JSON;
using myControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class FriendsList : Form
    {
        private int originPort = 7777;

        //用于保存好友请求信息
        public Dictionary<string, String[]> dirFriendRequest = new Dictionary<string, String[]>();

        public IPAddress myIPAddress;

        System.Timers.Timer timer = null;

        public ChatListSubItem me;
        public FriendsList(ChatListSubItem me)
        {
            InitializeComponent();
            this.me = me;
        }

        //用于保存所有聊天窗口列表
        public Dictionary<string, Chat> dirChat = new Dictionary<string, Chat>();
        //用于保存所有聊天室窗口列表
        public Dictionary<string, ChatRoom> dirChatRoom = new Dictionary<string, ChatRoom>();

        //监听服务器
        public Socket socketClient = null;
        private Thread threadClient = null;

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        private void Chat_Load(object sender, EventArgs e)
        {
            ServerIP serverIP = new ServerIP(PublicTool.GetAppConfig("mySqlConn"));
            JsonData ipData = serverIP.ExecuteSimpleQuery("");
            if (ipData.Count == 0)
            {
                MessageBox.Show("服务器IP异常");
                return;
            }
            try
            {
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress serverIPAddress = IPAddress.Parse(ipData[0]["IP"].ToString());
                int serverPort = int.Parse(ipData[0]["Port"].ToString());
                IPEndPoint endpoint = new IPEndPoint(serverIPAddress, serverPort);
                socketClient.Connect(endpoint);
                byte[] arrClientMsg = Encoding.UTF8.GetBytes("0#" + me.ID);
                socketClient.Send(arrClientMsg);//在服务器上注册
                //创建一个新线程 用于监听服务端发来的信息(服务器通知客户端好友上线等)
                threadClient = new Thread(RecMsg);
                threadClient.IsBackground = true;
                threadClient.Start();
            }
            catch
            {
                MessageBox.Show("连接服务器异常", "异常", MessageBoxButtons.OK);
                Application.Exit();
            }

            head_panel.BackgroundImage = me.HeadImage;
            label1.Text = me.NicName;
            label2.Text = me.Signature;
            InitHistoryChatList();
            InitFriendsList();
            InitChatRoomList();
            FriendList_notifyIcon.Text = me.ID + "的聊天程序";

            UserInfo user = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
            JsonData res = user.ExecuteSimpleQuery("Account='" + me.ID + "'");
            if (res.Count > 0)
            {
                myIPAddress = IPAddress.Parse(res[0]["IpAddress"].ToString());
                return;
            }
        }

        /// <summary>
        /// 接受服务端发来信息
        /// </summary>
        private void RecMsg()
        {
            string strSRecMsg = null;
            long fileLength = 0;
            string fileName = String.Empty;
            FileDownload itemLeft = null;
            while (true)
            {
                string strRecMsg = null;
                int length = 0;
                byte[] buffer = new byte[SendBufferSize];
                try
                {
                    length = socketClient.Receive(buffer);
                }
                catch
                {
                    continue;
                }
                if (buffer[0] == 1)//1为文件名字和长度
                {
                    string fileNameWithLength = Encoding.UTF8.GetString(buffer, 1, length - 1);
                    string[] fileInfo = fileNameWithLength.Split('#');
                    strSRecMsg = fileInfo[0]; //文件名
                    fileLength = Convert.ToInt64(fileInfo[1]);
                    fileName = fileInfo[2];
                }
                else if (buffer[0] == 2)//2为文件
                {
                    string fileNameSuffix = strSRecMsg.Substring(strSRecMsg.LastIndexOf('.')); //文件后缀
                    string mapPath = System.Windows.Forms.Application.StartupPath + "/userfile/";
                    if (Directory.Exists(mapPath) == false)
                    {
                        Directory.CreateDirectory(mapPath);
                    }
                    string savePath = mapPath + fileName;
                    //保存文件
                    int received = 0;
                    long receivedTotalFilelength = 0;
                    bool firstWrite = true;
                    using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                    {
                        RoundPanel panel = itemLeft.Controls["Message_roundPanel"] as RoundPanel;
                        ProgressBar bar = panel.Controls["progressBar1"] as ProgressBar;
                        bar.Maximum = (int)(fileLength / buffer.Length);
                        while (receivedTotalFilelength < fileLength) //之后收到的文件字节数组
                        {
                            if (bar.Value < bar.Maximum)
                            {
                                bar.PerformStep();
                            }
                            if (firstWrite)
                            {
                                fs.Write(buffer, 1, length - 1); //第一次收到的文件字节数组 需要移除标识符1 后写入文件
                                fs.Flush();
                                receivedTotalFilelength += length - 1;
                                firstWrite = false;
                                continue;
                            }
                            received = socketClient.Receive(buffer); //之后每次收到的文件字节数组 可以直接写入文件
                            fs.Write(buffer, 0, received);
                            fs.Flush();
                            receivedTotalFilelength += received;
                        }
                        fs.Close();
                        bar.Visible = false;
                        panel.Controls["UploadDone_label"].Text = "下载完成";
                        panel.Controls["DownLoad_button"].Visible = false;
                        itemLeft.filePath = savePath.Replace("/", "\\");
                        itemLeft.isReady = true;
                    }
                }
                else
                {
                    //将套接字获取到的字节数组转换为人可以看懂的字符串
                    strRecMsg = Encoding.UTF8.GetString(buffer, 0, length);
                    if (strRecMsg.Trim() == "")
                        continue;
                    string[] message = strRecMsg.Split('#');
                    if (message[0] == "1")
                    {
                        HistoryChatList_ChatListView.Items.Clear();
                        Friends_chatListBox.Items.Clear();
                        InitHistoryChatList();
                        InitFriendsList();
                        PublicTool.PlaySound(System.Windows.Forms.Application.StartupPath + "/Resources/Audio/online.wav");
                    }
                    else if (message[0] == "2")//好友请求
                    {
                        //StateChange_label.Tag = message;
                        string remoteID = message[1];
                        if (!dirFriendRequest.ContainsKey(remoteID))
                        {
                            dirFriendRequest.Add(remoteID, message);
                        }
                        string remoteIp = message[2];
                        string remotePort = message[3];
                        UserInfo friend = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
                        if (friend.Update("OnLineState='1',IpAddress='" + remoteIp + "',Port='" + remotePort + "'", "Account = '" + remoteID + "'"))
                        {
                            HistoryChatList_ChatListView.Items.Clear();
                            InitHistoryChatList();
                        }
                        HistoryChatList_ChatListView.SetSubItemTwinkle(remoteID, true);
                        PublicTool.PlaySound(System.Windows.Forms.Application.StartupPath + "/Resources/Audio/ding.wav");
                        if (timer == null)
                        {
                            timer = new System.Timers.Timer(800);
                            timer.Elapsed += new System.Timers.ElapsedEventHandler(theout); //到达时间的时候执行事件；
                            timer.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；   
                            timer.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件；
                        }
                        timer.Start();
                        FriendList_notifyIcon.Tag = "1";
                        FriendList_notifyIcon.Text = remoteID + "请求聊天";
                    }
                    else if (message[0] == "3")//检查文件
                    {
                        string friendAccount = message[2];
                        string fileInfoID = message[1];
                        int count = dirChat[friendAccount].GetFileInfo(fileInfoID, socketClient);
                        itemLeft = dirChat[friendAccount].Controls["ChatLog_panel"].Controls[count] as FileDownload;
                    }
                    else if (message[0] == "4")//加群申请
                    {
                        PublicTool.PlaySound(System.Windows.Forms.Application.StartupPath + "/Resources/Audio/ding.wav");
                        string fromUser = message[1];
                        string chatRoomID = message[2];
                        if (timer == null)
                        {
                            timer = new System.Timers.Timer(800);
                            timer.Elapsed += new System.Timers.ElapsedEventHandler(theout); //到达时间的时候执行事件；
                            timer.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；   
                            timer.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件；
                        }
                        timer.Start();
                        FriendList_notifyIcon.Tag = "2#" + chatRoomID + "#" + fromUser;
                        FriendList_notifyIcon.Text = fromUser + "请求您加群";
                    }
                    else if (message[0] == "5")//好友申请
                    {
                        PublicTool.PlaySound(System.Windows.Forms.Application.StartupPath + "/Resources/Audio/ding.wav");
                        if (timer == null)
                        {
                            timer = new System.Timers.Timer(800);
                            timer.Elapsed += new System.Timers.ElapsedEventHandler(theout); //到达时间的时候执行事件；
                            timer.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)；   
                            timer.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件；
                        }
                        string friendAccount = message[1];
                        timer.Start();
                        FriendList_notifyIcon.Tag = "3#" + friendAccount;
                        FriendList_notifyIcon.Text = friendAccount + "请求加您为好友";
                    }
                    else if (message[0] == "6")//刷新当前好友列表
                    {
                        InitHistoryChatList();
                        InitFriendsList();
                        PublicTool.PlaySound(System.Windows.Forms.Application.StartupPath + "/Resources/Audio/ding.wav");
                    }
                }
            }
        }

        /// <summary>
        /// 初始化理历史会话列表
        /// </summary>
        public void InitHistoryChatList()
        {
            HistoryChatList_ChatListView.Items.Clear();
            SessionList sessionList = new SessionList(PublicTool.GetAppConfig("mySqlConn"));
            JsonData sort = new JsonData();
            sort["field"] = "AddTime";
            sort["type"] = "desc";
            JsonData res = sessionList.ExecuteSimpleQueryWithSort("Owner='" + this.me.ID + "'", sort);
            foreach (JsonData ob in res)
            {
                string remarkName = ob["Remark"].ToString();
                string nickName = ob["NickName"].ToString();
                ChatListSubItem subItem = new ChatListSubItem(ob["FriendAccount"].ToString(), nickName, (remarkName == "" ? nickName : remarkName), ob["Signature"].ToString(), (ChatListSubItem.UserStatus)(int.Parse(ob["OnlineState"].ToString())), ob["Message"].ToString());
                subItem.HeadImage = Image.FromFile(@"Resources\img\" + ob["UserHeadImg"].ToString());
                subItem.LastMsgTime = PublicTool.DateStringFromNow(DateTime.Parse(ob["AddTime"].ToString()));
                string port = ob["Port"].ToString();
                if (port != "")
                {
                    subItem.TcpPort = int.Parse(port);
                }
                HistoryChatList_ChatListView.Items.Add(subItem);
            }
        }

        /// <summary>
        /// 初始化好友列表
        /// </summary>
        public void InitFriendsList()
        {
            Friends_chatListBox.Items.Clear();
            Friend friend = new Friend(PublicTool.GetAppConfig("mySqlConn"));
            JsonData friendData = friend.GetFriendList(this.me.ID);
            foreach (JsonData item in friendData)
            {
                ChatListItem friendListItem = new ChatListItem(item["group"]["GroupName"].ToString());
                foreach (JsonData ob in item["friends"])
                {
                    string remarkName = ob["Remark"].ToString();
                    string nickName = ob["NickName"].ToString();
                    ChatListSubItem subItem = new ChatListSubItem(ob["FriendAccount"].ToString(), nickName, (remarkName == "" ? nickName : remarkName), ob["Signature"].ToString(), (ChatListSubItem.UserStatus)(int.Parse(ob["OnlineState"].ToString())));
                    subItem.HeadImage = Image.FromFile(@"Resources\img\" + ob["UserHeadImg"].ToString());
                    subItem.IpAddress = ob["IpAddress"].ToString();
                    string port = ob["Port"].ToString();
                    if (port != "")
                    {
                        subItem.TcpPort = int.Parse(port);
                    }
                    friendListItem.SubItems.AddAccordingToStatus(subItem);
                }
                //friendListItem.SubItems.Sort();
                Friends_chatListBox.Items.Add(friendListItem);
            }
        }

        /// <summary>
        /// 初始化聊天室列表
        /// </summary>
        public void InitChatRoomList()
        {
            CharRoom_chatListView.Items.Clear();
            Chatroom chatRoom = new Chatroom(PublicTool.GetAppConfig("mySqlConn"));
            JsonData res = chatRoom.ExecuteSimpleQuery("Owner='" + this.me.ID + "'");
            foreach (JsonData ob in res)
            {
                string name = ob["Name"].ToString();
                ChatListSubItem subItem = new ChatListSubItem(ob["ID"].ToString(), name, "", "", ChatListSubItem.UserStatus.Online, ob["Remarks"].ToString());
                subItem.HeadImage = Image.FromFile(@"Resources\img\" + ob["CoverImage"].ToString());
                subItem.LastMsgTime = ob["OnlineMemberCount"].ToString() + "/" + ob["MemberCount"].ToString() + "  ";
                CharRoom_chatListView.Items.Add(subItem);
            }
        }

        /// <summary>
        /// 双击打开聊天面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryChatList_ChatListView_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            SendMessage(e.SelectSubItem);
        }

        /// <summary>
        /// 显示右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryChatList_ChatListView_MouseRightClickSubItem(object sender, ChatListEventArgs e)
        {
            if (e.MouseOnSubItem == null)
                return;
            MouseRightMenu_contextMenuStrip.Show(Cursor.Position);
            MouseRightMenu_contextMenuStrip.Tag = e.MouseOnSubItem;
        }

        private void Exit_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 刷新聊天历史列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 刷新列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryChatList_ChatListView.Items.Clear();
            InitHistoryChatList();
        }

        /// <summary>
        /// 右键菜单发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nihaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatListSubItem subItem = (ChatListSubItem)MouseRightMenu_contextMenuStrip.Tag;
            SendMessage(subItem);
        }

        private void SendMessage(ChatListSubItem subItem)
        {
            string friendAccount = subItem.ID;
            if (dirChat.ContainsKey(friendAccount))
            {
                dirChat[friendAccount].Show();
            }
            else
            {
                if (dirFriendRequest != null && dirFriendRequest.ContainsKey(friendAccount))
                {
                    string[] message = dirFriendRequest[friendAccount];
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPAddress serverIPAddress = IPAddress.Parse(message[2]);
                    int serverPort = int.Parse(message[3].ToString());
                    IPEndPoint endpoint = new IPEndPoint(serverIPAddress, serverPort);
                    socket.Connect(endpoint);
                    Chat chat = new Chat(Friends_chatListBox.GetSubItemsById(friendAccount)[0], me);
                    chat.socConnection = socket;
                    chat.BeCallFlag = true;
                    chat.Owner = this;
                    chat.serverSocket = socketClient;
                    dirChat.Add(friendAccount, chat);
                    dirFriendRequest.Remove(friendAccount);
                    HistoryChatList_ChatListView.SetSubItemTwinkle(friendAccount, false);
                    chat.Show();
                }
                else
                {
                    int port = GetAvailablePort();
                    byte[] arrClientMsg = Encoding.UTF8.GetBytes("2#" + me.ID + "#" + friendAccount + "#" + this.myIPAddress.ToString() + "#" + port);
                    byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                    sendMessage[0] = 0;
                    Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                    socketClient.Send(sendMessage);
                    Chat chat = new Chat(subItem, me);
                    chat.Owner = this;
                    chat.serverSocket = socketClient;
                    chat.port = port;
                    dirChat.Add(friendAccount, chat);
                    chat.Show();
                }

                if (dirFriendRequest != null && dirFriendRequest.Count == 0)
                {
                    ResetNotifyIconBar();
                }
            }
        }

        /// <summary>
        ///右键菜单删除聊天历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除当前会话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatListSubItem subItem = (ChatListSubItem)MouseRightMenu_contextMenuStrip.Tag;
            HistoryChatList_ChatListView.Items.Remove(subItem);
            SessionList sessionList = new SessionList(PublicTool.GetAppConfig("mySqlConn"));
            sessionList.Delete("ID='" + subItem.ItemID + "'");
        }

        /// <summary>
        /// 隐藏到任务栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hide_toolStripButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal && this.Visible == true)
            {
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        /// <summary>
        /// 任务栏按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriendList_notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                TaskMenu_contextMenuStrip.Show();
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized || this.Visible == false)
                {
                    this.Show();
                    this.ShowInTaskbar = true;
                }
                else
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                }
                if (timer != null && FriendList_notifyIcon.Tag.ToString() == "1")
                {
                    ResetNotifyIconBar();
                    //查询dirFriendRequest列表,依次创建聊天窗口
                    List<string> removeString = new List<string>();
                    foreach (KeyValuePair<string, string[]> item in dirFriendRequest)
                    {
                        string[] message = item.Value;
                        string key = item.Key;
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        IPAddress serverIPAddress = IPAddress.Parse(message[2]);
                        int serverPort = int.Parse(message[3].ToString());
                        IPEndPoint endpoint = new IPEndPoint(serverIPAddress, serverPort);
                        socket.Connect(endpoint);
                        Chat chat = new Chat(Friends_chatListBox.GetSubItemsById(key)[0], me);
                        chat.socConnection = socket;
                        chat.BeCallFlag = true;
                        chat.serverSocket = socketClient;
                        chat.Owner = this;
                        dirChat.Add(key, chat);
                        removeString.Add(key);
                        chat.Show();
                    }
                    foreach (string remove in removeString)
                    {
                        HistoryChatList_ChatListView.SetSubItemTwinkle(remove, false);
                        dirFriendRequest.Remove(remove);
                    }
                }
                else if (timer != null && FriendList_notifyIcon.Tag.ToString()[0] == '2')
                {
                    string[] info = FriendList_notifyIcon.Tag.ToString().Split('#');
                    ResetNotifyIconBar();
                    NotificationShow msgWin = new NotificationShow(info[2], info[1], "1");
                    msgWin.Owner = this;
                    msgWin.Show();
                }
                else if (timer != null && FriendList_notifyIcon.Tag.ToString()[0] == '3')
                {
                    string[] info = FriendList_notifyIcon.Tag.ToString().Split('#');
                    ResetNotifyIconBar();
                    NotificationShow msgWin = new NotificationShow(info[1], me.ID, "0");
                    msgWin.Owner = this;
                    msgWin.Show();
                }
            }
        }

        /// <summary>
        /// 重置状态栏
        /// </summary>
        private void ResetNotifyIconBar()
        {
            if (timer != null)
            {
                timer.Stop();
                FriendList_notifyIcon.Tag = "0";
                FriendList_notifyIcon.Icon = new Icon(System.Windows.Forms.Application.StartupPath + "/Resources/img/login_form.ico");
                FriendList_notifyIcon.Text = me.ID + "的聊天程序";
            }

        }

        /// <summary>
        /// 状态栏退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoHide_timer_Tick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;  //屏幕宽度 
                int ScreenRight = Screen.PrimaryScreen.WorkingArea.Right; //屏幕高度 
                int MouseX = Control.MousePosition.X; //鼠标X位置 
                int MouseY = Control.MousePosition.Y;//鼠标垂直位置 
                if (this.Left < 0 && this.Top < 0)
                {
                    this.Left = 0;
                    this.Top = 1;
                }
                if (this.Left >= ScreenWidth - this.Right && this.Top < 0) //如果自己的左边是否在屏幕的边缘 
                {
                    this.Left = ScreenWidth;
                    this.Top = 0;
                }
                if (this.Top < 0 && MouseX > this.Left && MouseX < this.Left + this.Width && MouseY < 3)
                {
                    this.Top = 0;
                }
                if (this.Top <= 0 && this.Left > 0 && this.Left < ScreenWidth - this.Width)
                {
                    if (MouseX < this.Left || MouseX > this.Left + this.Width || MouseY > this.Top + this.Right)
                    {
                        this.Top = 3 - this.Right;
                    }
                }
                if (this.Left < 0 && MouseY > this.Top && MouseY < this.Top + this.Width && MouseX < 3)
                {
                    this.Left = 0;
                }
                if (this.Left <= 0 && this.Top > 0 && this.Top < ScreenRight - this.Right)
                {
                    if (MouseY < this.Top || MouseY > this.Top + this.Right || MouseX > this.Width)
                    {
                        this.Left = 3 - this.Width;
                    }
                }

                if (this.Left >= ScreenWidth - this.Width && this.Top > 0 && this.Top < ScreenRight - this.Width)
                {
                    if (MouseY < this.Top || MouseY > this.Top + this.Right || MouseX < ScreenWidth - this.Width)
                    {
                        this.Left = ScreenWidth - 3;
                    }
                }

                if (this.Left > ScreenWidth - 5)　//判断自己的左边是否隐藏了 
                {
                    if (MouseX > ScreenWidth - 5)  //如果隐藏了  判断鼠标是不在屏幕的边缘 
                    {
                        this.Left = ScreenWidth - this.Width;
                    }
                }
            }
        }

        private void FriendsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                byte[] arrClientMsg = Encoding.UTF8.GetBytes("1#" + me.ID);
                byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                sendMessage[0] = 0;
                Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                socketClient.Send(sendMessage);//通知服务器下线
            }
            catch { }
        }

        /// <summary>
        /// 得到一个可用的端口
        /// </summary>
        /// <returns></returns>
        private int GetAvailablePort()
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
            while (true)
            {
                bool isUse = false;
                this.originPort++;
                foreach (IPEndPoint endPoint in ipEndPoints)
                {
                    if (endPoint.Port == this.originPort)
                    {
                        isUse = true;
                        break;
                    }
                }
                if (!isUse)
                    break;
            }
            return this.originPort;
        }

        private void StateChange_label_Click(object sender, EventArgs e)
        {

        }

        private int twinkle = 0;

        /// <summary>
        /// 状态栏闪烁图标以通知好友发起聊天
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (twinkle < 1)
                {
                    FriendList_notifyIcon.Icon = new Icon(System.Windows.Forms.Application.StartupPath + "/Resources/img/login_form.ico");
                    twinkle++;
                    return;
                }
                else
                    FriendList_notifyIcon.Icon = new Icon(System.Windows.Forms.Application.StartupPath + "/Resources/img/notify.ico");
                twinkle = 0;
            }
            catch { }
        }

        /// <summary>
        /// 改变在线状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StateChange_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SearchFriends search = new SearchFriends();
            search.Owner = this;
            search.Me = me.ID;
            search.Show();
        }

        private void 创建聊天室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddChatRoom chatRoom = new AddChatRoom();
            chatRoom.Owner = this;
            chatRoom.userID = me.ID;
            chatRoom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NotificationShow msgWin = new NotificationShow("", "", "1");
            //msgWin.Owner = this;
            //msgWin.Show();
            new ChatRoom("sds").Show();
        }

        private void CharRoom_chatListView_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            SendChatRoomMessage(e.SelectSubItem);
        }

        private void SendChatRoomMessage(ChatListSubItem subItem)
        {
            string chatRoomID = subItem.ID;
            if (dirChatRoom.ContainsKey(chatRoomID))
            {
                dirChatRoom[chatRoomID].Show();
            }
            else
            {
                ChatRoom room = new ChatRoom(chatRoomID);
                room.Owner = this;
                dirChatRoom.Add(chatRoomID, room);
                room.Show();
            }
        }

        private void CharRoom_chatListView_MouseRightClickSubItem(object sender, ChatListEventArgs e)
        {

            if (e.MouseOnSubItem == null)
                return;
            MouseRightMenu_contextMenuStrip.Show(Cursor.Position);
            MouseRightMenu_contextMenuStrip.Tag = e.MouseOnSubItem;
        }

        private void Friends_chatListBox_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            SendMessage(e.SelectSubItem);
        }

        private void Friends_chatListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ChatListSubItem item = Friends_chatListBox.SelectSubItem;
                if (item == null)
                    return;
                MouseRightMenu_contextMenuStrip.Show(Cursor.Position);
                MouseRightMenu_contextMenuStrip.Tag = item;
            }
        }

        private void files_toolStripButton_Click(object sender, EventArgs e)
        {
            FileManage fileManage = new FileManage();
            fileManage.Show();
        }

        private void setting_toolStripButton_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo(PublicTool.GetAppConfig("mySqlConn"));
            if (user.Delete("Account='" + me.ID + "'"))
            {
                MessageBox.Show("当前用户被彻底注销,点击退出.");
                this.Close();
            }
        }

    }
}
