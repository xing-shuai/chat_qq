using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chat.Entity;
using Chat.Public;
using MyClassLibrary.JSON;

namespace Chat.CustomControl
{
    public partial class FileDownload : UserControl
    {
        public FileDownload()
        {
            InitializeComponent();
        }
        public bool isReady = false;

        public string filePath = String.Empty;

        public string fileID = String.Empty;
        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isReady)
            {
                string folderPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
                if (!System.IO.Directory.Exists(folderPath))
                {
                    MessageBox.Show("文件夹不存在", "操作提示");
                    return;
                }
                System.Diagnostics.Process.Start(folderPath);
            }
            else
            {
                MessageBox.Show("正在传输", "操作提示");
            }
        }

        private void Option_button_Click(object sender, EventArgs e)
        {
            Option_contextMenuStrip.Show(Cursor.Position);
            //Option_contextMenuStrip.Tag = this.filePath;
        }

        private void OpenFile_button_Click(object sender, EventArgs e)
        {
            if (isReady)
            {
                if (!System.IO.File.Exists(filePath))
                {
                    MessageBox.Show("该文件不存在", "操作提示");
                    return;
                }
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("正在传输", "操作提示");
            }
        }

        private void DownLoad_button_Click(object sender, EventArgs e)
        {
            byte[] arrClientMsg = Encoding.UTF8.GetBytes("3#" + this.fileID);
            byte[] sendMessage = new byte[arrClientMsg.Length + 1];
            sendMessage[0] = 0;
            Buffer.BlockCopy(arrClientMsg, 0, sendMessage, 1, arrClientMsg.Length);
            this.socketServer.Send(sendMessage);
        }

        public void Init(string fileInfoID)
        {
            this.fileID = fileInfoID;
            ResentChatFile file = new ResentChatFile(PublicTool.GetAppConfig("mySqlConn"));
            JsonData data = file.ExecuteSimpleQuery("ID='" + fileInfoID + "'");
            FileName_label.Text = data[0]["FileName"].ToString();
            FileSize_label.Text = data[0]["Size"].ToString();
            FileType_label.Text = data[0]["Type"].ToString();
            FileTypeImg_panel.BackgroundImage = PublicTool.GetFileTypeImage(data[0]["Type"].ToString());
        }

        public System.Net.Sockets.Socket socketServer { get; set; }
    }
}
