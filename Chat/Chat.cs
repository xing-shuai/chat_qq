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
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Chat : Form
    {
        int msgHeight = 0;

        public bool BeCallFlag = false;

        public int port;
        private ChatListSubItem me;

        private ChatListSubItem friend;

        private Socket socketClient = null;//连接套接字
        Thread threadClient = null;//接收信息线程
        public Socket socConnection = null;

        public const long SendBufferSize = 1024 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        public Chat(ChatListSubItem friend, ChatListSubItem me)
        {
            InitializeComponent();
            this.friend = friend;
            this.me = me;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            FriendName_label.Text = this.friend.NicName == "" ? this.friend.DisplayName : this.friend.NicName;
            FriendSignature_label.Text = this.friend.Signature;
            if (this.friend.Status == ChatListSubItem.UserStatus.OffLine)
                FriendHeadImg_panel.BackgroundImage = this.friend.GetDarkImage();
            else
                FriendHeadImg_panel.BackgroundImage = this.friend.HeadImage;

            if (!BeCallFlag)
            {
                if (this.friend.Status == ChatListSubItem.UserStatus.Online)
                {
                    try
                    {
                        //监听自身端口
                        socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        IPEndPoint endpointSelf = new IPEndPoint((this.Owner as FriendsList).myIPAddress, port);
                        //将负责监听的套接字绑定网络端点
                        socketClient.Bind(endpointSelf);
                        //将套接字的监听队列长度设置为20
                        socketClient.Listen(20);
                        //创建一个负责监听客户端的线程 
                        threadClient = new Thread(WatchConnecting);
                        //将窗体线程设置为与后台同步
                        threadClient.IsBackground = true;
                        threadClient.Start();
                    }
                    catch
                    {
                        //让服务器通知好友弹出
                    }
                }
            }
            else
            {
                Thread thread = new Thread(RecMsg);
                thread.IsBackground = true;
                thread.Start();
            }

            if (face == null)
            {
                Thread thread = new Thread(InitFace);
                thread.IsBackground = true;
                thread.Start();
            }
        }

        private void InitFace(object obj)
        {
            face = new Face();
            face.Init();
            face.PicClick += new Face.picClickHandle(pic_Click);
        }

        /// <summary>
        /// 发送信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Input_textBox.Select(0, Input_textBox.Text.Length);
            Input_textBox.SelectionColor = Color.White;
            string inputMessage = Input_textBox.Rtf;
            if (inputMessage == "")
            {
                return;
            }
            try
            {
                byte[] arrClientMsg = Encoding.UTF8.GetBytes(inputMessage);
                byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                sendMessage[0] = 0;
                Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                socConnection.Send(sendMessage);
                ShowSendMessage(inputMessage);
                Input_textBox.Clear();
            }
            catch
            {
                Input_textBox.Clear();
            }
        }


        /// <summary>
        /// 持续不断监听好友发来的连接请求
        /// </summary>
        private void WatchConnecting()
        {
            while (true)
            {
                //MessageBox.Show("客户端发来链接");
                try
                {
                    socConnection = socketClient.Accept();
                }
                catch
                {
                    continue;
                }
                try
                {
                    Thread thread = new Thread(RecMsg);
                    thread.IsBackground = true;
                    thread.Start();
                }
                catch
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// 接受发来信息
        /// </summary>
        private void RecMsg()
        {
            string strSRecMsg = null;
            //long fileLength = 0;
            Dictionary<string, byte[]> fileDictionary = new Dictionary<string, byte[]>();//接收文件的字典

            while (true) //持续监听服务端发来的消息
            {
                int length = 0;
                byte[] buffer = new byte[SendBufferSize];
                try
                {
                    //将客户端套接字接收到的字节数组存入内存缓冲区, 并获取其长度
                    length = socConnection.Receive(buffer);

                    if (length > 0) //接受到的长度大于0 说明有信息或文件传来
                    {
                        if (buffer[0] == 0) //0为文字信息
                        {
                            strSRecMsg = Encoding.UTF8.GetString(buffer, 1, length - 1);
                            ShowReciveMessage(strSRecMsg);
                        }
                        #region
                        //if (buffer[0] == 1)//2为文件名字和长度
                        //{
                        //    string fileNameWithLength = Encoding.UTF8.GetString(buffer, 1, length - 1);
                        //    strSRecMsg = fileNameWithLength.Split('-')[0]; //文件名
                        //    fileLength = Convert.ToInt64(fileNameWithLength.Split('-').Last());
                        //    if (!fileDictionary.ContainsKey(strSRecMsg))
                        //    {
                        //        fileDictionary.Add(strSRecMsg, null);
                        //    }
                        //}
                        //if (buffer[0] == 2)//1为文件
                        //{
                        //    string fileNameSuffix = strSRecMsg.Substring(strSRecMsg.LastIndexOf('.')); //文件后缀
                        //    SaveFileDialog sfDialog = new SaveFileDialog()
                        //    {
                        //        Filter = "(*" + fileNameSuffix + ")|*" + fileNameSuffix + "", //文件类型
                        //        FileName = strSRecMsg
                        //    };

                        //    //如果点击了对话框中的保存文件按钮 
                        //    if (sfDialog.ShowDialog(this) == DialogResult.OK)
                        //    {
                        //        string savePath = sfDialog.FileName; //获取文件的全路径
                        //        //保存文件
                        //        int received = 0;
                        //        long receivedTotalFilelength = 0;
                        //        bool firstWrite = true;
                        //        using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                        //        {
                        //            while (receivedTotalFilelength < fileLength) //之后收到的文件字节数组
                        //            {
                        //                if (firstWrite)
                        //                {
                        //                    fs.Write(buffer, 1, length - 1); //第一次收到的文件字节数组 需要移除标识符1 后写入文件
                        //                    fs.Flush();
                        //                    receivedTotalFilelength += length - 1;

                        //                    firstWrite = false;
                        //                    continue;
                        //                }
                        //                received = socConnection.Receive(buffer); //之后每次收到的文件字节数组 可以直接写入文件
                        //                fs.Write(buffer, 0, received);
                        //                fs.Flush();

                        //                receivedTotalFilelength += received;
                        //            }
                        //            fs.Close();
                        //        }

                        //        string fName = savePath.Substring(savePath.LastIndexOf("\\") + 1); //文件名 不带路径
                        //        string fPath = savePath.Substring(0, savePath.LastIndexOf("\\")); //文件路径 不带文件名
                        //        //txtMsg.AppendText("天之涯:" + GetCurrentTime() + "\r\n您成功接收了文件" + fName + "\r\n保存路径为:" + fPath + "\r\n");
                        //    }
                        //}
                        #endregion
                        else if (buffer[0] == 2)//窗口抖动
                        {
                            ShakeWindow();
                            ShowShakeMessage(friend.ID + "向您发送了抖动窗口");
                        }
                    }
                }
                catch
                {
                    continue;
                }

                if (length == 0)
                {
                    break;
                }
            }
        }

        private void ShakeWindow()
        {
            Point first = this.Location;
            for (int i = 0; i < 8; i++)
            {
                Random ran = new Random();
                Point p = new Point(this.Location.X + ran.Next(10) - 4, this.Location.Y +
                    ran.Next(10) - 4);
                System.Threading.Thread.Sleep(15);//当前线程挂起15毫秒
                this.Location = p;
                System.Threading.Thread.Sleep(15);//当前线程再挂起15毫秒
            }
            this.Location = first;   //将窗体还原为原来的位置
        }


        /// <summary>
        /// 浏览发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SendFile_openFileDialog.ShowDialog();
        }

        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendFile_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string fileFullPath = SendFile_openFileDialog.FileName;
            if (string.IsNullOrEmpty(fileFullPath))
            {
                MessageBox.Show("请选择需要发送的文件!");
                return;
            }
            FileUpLoad itemRight = new FileUpLoad();
            itemRight.Init(fileFullPath);
            itemRight.Width = ChatLog_panel.Width - 35;

            if (msgHeight > ChatLog_panel.Height)
            {
                ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
                itemRight.Location = new Point(0, ChatLog_panel.Height);
            }
            else
            {
                itemRight.Location = new Point(10, msgHeight);
                msgHeight += itemRight.Height;
            }

            itemRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            itemRight.Controls["Message_roundPanel"].MouseWheel += new MouseEventHandler(msg_OnMouseWheel);

            ChatLog_panel.Controls.Add(itemRight);
            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.HorizontalScroll.Visible = false;

            Thread thread = new Thread(new ThreadStart(
                delegate
                {
                    SendFile(itemRight);
                }
           ));
            thread.IsBackground = true;
            thread.Start();
        }

        public int GetFileInfo(string fileInfoID, Socket socketClient)
        {
            FileDownload itemLeft = new FileDownload();
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { GetFileInfo(fileInfoID, socketClient); }));
                return ChatLog_panel.Controls.Count - 1;
            }

            itemLeft.Init(fileInfoID);
            itemLeft.socketServer = socketClient;
            itemLeft.Width = ChatLog_panel.Width - 40;
            if (msgHeight > ChatLog_panel.Height)
            {
                ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
                itemLeft.Location = new Point(10, ChatLog_panel.Height);
            }
            else
            {
                itemLeft.Location = new Point(10, msgHeight);
                msgHeight += itemLeft.Height;
            }

            itemLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));

            itemLeft.Controls["Message_roundPanel"].MouseWheel += new MouseEventHandler(msg_OnMouseWheel);
            ChatLog_panel.Controls.Add(itemLeft);

            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.HorizontalScroll.Visible = false;
            return ChatLog_panel.Controls.Count - 1;
        }

        private void SendFile(FileUpLoad itemRight)
        {
            //if (this.InvokeRequired)
            //{
            //    this.Invoke(new MethodInvoker(delegate { SendFile(); }));
            //    return;
            //}

            string fileFullPath = SendFile_openFileDialog.FileName;

            //文件上传至服务器
            //发送文件之前 将文件名字和长度发送过去
            long fileLength = new FileInfo(fileFullPath).Length;
            string totalMsg = string.Format("{0}-{1}-{2}-{3}", fileFullPath.Substring(fileFullPath.LastIndexOf('\\') + 1), fileLength, me.ID, friend.ID);

            byte[] arrClientMsg = Encoding.UTF8.GetBytes(totalMsg);
            byte[] sendMessage = new byte[arrClientMsg.Length + 1];
            sendMessage[0] = 1;
            Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
            this.serverSocket.Send(sendMessage);

            //发送文件
            byte[] buffer = new byte[SendBufferSize];

            using (FileStream fs = new FileStream(fileFullPath, FileMode.Open, FileAccess.Read))
            {
                int readLength = 0;
                bool firstRead = true;
                long sentFileLength = 0;
                RoundPanel panel = itemRight.Controls["Message_roundPanel"] as RoundPanel;
                ProgressBar bar = panel.Controls["progressBar1"] as ProgressBar;
                bar.Maximum = (int)(fileLength / buffer.Length);
                while ((readLength = fs.Read(buffer, 0, buffer.Length)) > 0 && sentFileLength < fileLength)
                {
                    if (bar.Value < bar.Maximum)
                    {
                        bar.PerformStep();
                    }
                    sentFileLength += readLength;
                    //在第一次发送的字节流上加个前缀1
                    if (firstRead)
                    {
                        byte[] firstBuffer = new byte[readLength + 1];
                        firstBuffer[0] = 2; //告诉机器该发送的字节数组为文件
                        Buffer.BlockCopy(buffer, 0, firstBuffer, 1, readLength);
                        this.serverSocket.Send(firstBuffer, 0, readLength + 1, SocketFlags.None);
                        firstRead = false;
                        continue;
                    }
                    //之后发送的均为直接读取的字节流
                    this.serverSocket.Send(buffer, 0, readLength, SocketFlags.None);
                }
                fs.Close();
                bar.Visible = false;
                panel.Controls["UploadDone_label"].Text = "上传完成";
                itemRight.isReady = true;
            }
        }

        /// <summary>
        /// 显示发送的消息
        /// </summary>
        /// <param name="message"></param>
        private void ShowSendMessage(string message)
        {
            ChatItemRight itemRight = new ChatItemRight();
            itemRight.Width = ChatLog_panel.Width - 35;
            this.lastMessage = itemRight.Init(me.NicName, me.HeadImage, message);
            if (msgHeight > ChatLog_panel.Height)
            {
                ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
                itemRight.Location = new Point(0, ChatLog_panel.Height);
            }
            else
            {
                itemRight.Location = new Point(10, msgHeight);
                msgHeight += itemRight.Height;
            }

            itemRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));

            itemRight.Controls["Message_roundPanel"].Controls["Msg_textBox"].MouseWheel += new MouseEventHandler(msg_OnMouseWheel);
            ChatLog_panel.Controls.Add(itemRight);

            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.HorizontalScroll.Visible = false;
        }

        /// <summary>
        /// 显示收到的信息
        /// </summary>
        /// <param name="message"></param>
        private void ShowReciveMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ShowReciveMessage(message); }));
                return;
            }

            ChatItemLeft itemLeft = new ChatItemLeft();
            itemLeft.Width = ChatLog_panel.Width - 40;
            this.lastMessage = itemLeft.Init(this.friend.NicName, this.friend.HeadImage, message);
            if (msgHeight > ChatLog_panel.Height)
            {
                ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
                itemLeft.Location = new Point(10, ChatLog_panel.Height);
            }
            else
            {
                itemLeft.Location = new Point(10, msgHeight);
                msgHeight += itemLeft.Height;
            }

            itemLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));

            itemLeft.Controls["Message_roundPanel"].Controls["Msg_textBox"].MouseWheel += new MouseEventHandler(msg_OnMouseWheel);
            ChatLog_panel.Controls.Add(itemLeft);

            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.HorizontalScroll.Visible = false;
        }

        /// <summary>
        /// 消息textbox滚动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msg_OnMouseWheel(object sender, MouseEventArgs e)
        {
            int set_y = 0;
            if (e.Delta > 0) //滑轮向上
            {
                set_y = ChatLog_panel.VerticalScroll.Value - 30;
            }
            if (e.Delta < 0)  //滑轮向下
            {
                set_y = ChatLog_panel.VerticalScroll.Value + 30;
            }
            if (set_y < ChatLog_panel.VerticalScroll.Maximum && set_y > ChatLog_panel.VerticalScroll.Minimum)
                ChatLog_panel.VerticalScroll.Value = set_y;
        }


        /// <summary>
        /// 输入框回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                this.button1_Click(sender, e);
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hide_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// 关闭时清除主窗口中维护的聊天窗口信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SessionList session = new SessionList(PublicTool.GetAppConfig("mySqlConn"));
                session.Delete("Owner='" + me.ID + "' and FriendAccount='" + friend.ID + "'");
                JsonData sessionData = new JsonData();
                sessionData["ID"] = Guid.NewGuid().ToString();
                sessionData["Owner"] = me.ID;
                sessionData["FriendAccount"] = friend.ID;
                sessionData["Message"] = this.lastMessage;
                sessionData["AddTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                session.Add(sessionData);
            }
            catch { }
            this.face.Visible = false;
            ((FriendsList)this.Owner).dirChat.Remove(this.friend.ID);

        }

        Face face;
        /// <summary>
        /// 表情面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (face == null)
            {
                return;
            }
            if (!face.isReady)
            {
                return;
            }

            if (face.Visible == false)
            {
                face.Location = new Point(0, this.Height - face.Height - 65);
                face.Visible = true;
                this.Controls.Add(face);
                face.BringToFront();
            }
            else
            {
                face.Visible = false;
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            Panel pic = sender as Panel;
            Clipboard.SetDataObject(pic.BackgroundImage);
            Input_textBox.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
            Clipboard.Clear();
            face.Visible = false;
        }

        public Socket serverSocket { get; set; }

        private void ShowShakeMessage(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { ShowShakeMessage(message); }));
                return;
            }
            Panel panel = new Panel();
            Label label = new Label();
            label.Text = message;
            panel.Width = ChatLog_panel.Width - 35;
            panel.Height = 20;
            panel.Controls.Add(label);
            if (msgHeight > ChatLog_panel.Height)
            {
                ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
                panel.Location = new Point(0, ChatLog_panel.Height);
            }
            else
            {
                panel.Location = new Point(10, msgHeight);
                msgHeight += panel.Height;
            }
            label.Location = new Point(panel.Width / 2 - 35, 7);
            label.ForeColor = Color.Gray;
            label.AutoSize = true;
            panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ChatLog_panel.Controls.Add(panel);

            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.VerticalScroll.Value = ChatLog_panel.VerticalScroll.Maximum;
            ChatLog_panel.HorizontalScroll.Visible = false;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ShakeWindow();
            try
            {
                byte[] arrClientMsg = Encoding.UTF8.GetBytes("");
                byte[] sendMessage = new byte[arrClientMsg.Length + 1];
                sendMessage[0] = 2;
                Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
                socConnection.Send(sendMessage);
                ShowShakeMessage("向" + friend.ID + "发送了抖动窗口");
            }
            catch { }
        }

        public string lastMessage { get; set; }
    }
}
