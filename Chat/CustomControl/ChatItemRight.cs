using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using myControlLibrary;

namespace Chat.CustomControl
{
    public partial class ChatItemRight : UserControl
    {
        public ChatItemRight()
        {
            InitializeComponent();
        }

        public string Init(string userName, Image userImage, string message)
        {
            this.Controls["UserHeade_panel"].BackgroundImage = userImage;
            this.Controls["UserName_label"].Text = userName;
            RoundPanel roundPanel = (RoundPanel)this.Controls["Message_roundPanel"];
            RichTextBox msgBox = (RichTextBox)roundPanel.Controls["Msg_textBox"];
            msgBox.Rtf = message;
            this.Controls["MsgTime_label"].Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

            MatchCollection zh = Regex.Matches(msgBox.Text, @"[\u4e00-\u9fa5]", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection zhDot = Regex.Matches(msgBox.Text, @"[，。；？~！：‘“”’【】（）]", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            int lineWidth = (zh.Count + zhDot.Count) * 9 + (msgBox.Text.Length - zh.Count - zhDot.Count) * 4;
            //接收数据内容中是否包含图像
            int havePic = 0;
            havePic = Regex.Matches(msgBox.Rtf, @"\{\\pict\\").Count;
            //加上图像宽度
            lineWidth += havePic * 13;
            if (lineWidth < 210)
            {
                roundPanel.Width = lineWidth + 30;
                roundPanel.Location = new Point(this.Width - lineWidth - 90, roundPanel.Location.Y);
            }
            else
            {
                this.Height = (lineWidth / 210 + 1) * 18 + 60;
            }
            return msgBox.Text;
        }
    }
}
