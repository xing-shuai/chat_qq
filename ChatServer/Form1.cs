using Chat.Entity;
using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread threadWatch = null;
        Socket socketWatch = null;


        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        /// <summary>
        /// 获取本地IPv4地址
        /// </summary>
        /// <returns>本地IPv4地址</returns>
        public IPAddress GetLocalIPv4Address()
        {
            IPAddress localIPv4 = null;
            //获取本机所有的IP地址列表
            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ipAddress in ipAddressList)
            {
                //判断是否是IPv4地址
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork) //AddressFamily.InterNetwork表示IPv4 
                {
                    localIPv4 = ipAddress;
                }
                else
                    continue;
            }
            return localIPv4;
        }

        private void StartServer_button_Click(object sender, EventArgs e)
        {
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress = GetLocalIPv4Address();
            int port = 6666;

            IPEndPoint endpoint = new IPEndPoint(ipAddress, port);
            //将负责监听的套接字绑定网络端点
            socketWatch.Bind(endpoint);
            //将套接字的监听队列长度设置为20
            socketWatch.Listen(20);
            //创建一个负责监听客户端的线程 
            threadWatch = new Thread(WatchConnecting);
            //将窗体线程设置为与后台同步
            threadWatch.IsBackground = true;
            threadWatch.Start();
            StartServer_button.Enabled = false;
            Info_textBox.AppendText("已启动服务\r\n");
            ServerIP serverIP = new ServerIP(GetAppConfig("mySqlConn"));
            JsonData data = new JsonData();
            data["IP"] = ipAddress.ToString();
            data["Port"] = port;
            serverIP.Delete("");
            if (serverIP.Add(data))
                Info_textBox.AppendText("服务器IP以更新\r\n");
            else
                Info_textBox.AppendText("服务器IP更新失败\r\n");
        }

        Socket socConnection = null;
        IPAddress clientIP; //访问客户端的IP
        int clientPort; //访问客户端的端口号

        /// <summary>
        /// 持续不断监听客户端发来的请求, 用于不断获取客户端发送过来的连续数据信息
        /// </summary>
        private void WatchConnecting()
        {
            while (true)
            {
                try
                {
                    socConnection = socketWatch.Accept();
                }
                catch (Exception ex)
                {
                    break;
                }
                //获取访问客户端的IP
                clientIP = (socConnection.RemoteEndPoint as IPEndPoint).Address;
                //获取访问客户端的Port
                clientPort = (socConnection.RemoteEndPoint as IPEndPoint).Port;

                byte[] buffer = new byte[ReceiveBufferSize];
                socConnection.Receive(buffer);
                string account = Encoding.UTF8.GetString(buffer);
                int index = account.IndexOf('\0');
                account = account.Substring(0, index);
                if (account == "")
                {
                    continue;
                }
                Friend friend = new Friend(GetAppConfig("mySqlConn"));
                if (friend.Update("OnLineState='1',IpAddress='" + clientIP.ToString() + "',Port='" + clientPort + "'", "FriendAccount = '" + account + "'"))
                    Info_textBox.AppendText("客户端" + account + "已登陆（ip:" + clientIP.ToString() + "port:" + clientPort + "）\r\n");
                else
                    Info_textBox.AppendText("客户端" + account + "登陆信息处理失败\r\n");
                //向此用户的好友发送上线通知


                ////创建通信线程 
                //ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                //Thread thread = new Thread(pts);
                //thread.IsBackground = true;
                ////启动线程
                //thread.Start(socConnection);
            }
        }


        private string GetAppConfig(string key)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                return config.AppSettings.Settings[key].Value;
            }
            catch
            {
                return null;
            }
        }

        private void CloseServer_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
