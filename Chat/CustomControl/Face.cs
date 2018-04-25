using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chat.CustomControl
{
    public partial class Face : UserControl
    {
        public Face()
        {
            InitializeComponent();
        }

        public bool isReady = false;
        public delegate void picClickHandle(object sender, EventArgs e);

        public event picClickHandle PicClick;


        public void Init()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { Init(); }));
                return;
            }
            DirectoryInfo folder = null;
            try
            {
                folder = new DirectoryInfo(@"Resources\Face\");
            }
            catch
            {
                folder = new DirectoryInfo(System.Windows.Forms.Application.StartupPath + "/Resources/Face/");
            }
            FileInfo[] fileInfo = folder.GetFiles();
            this.Width = 13 * 23 + 15;
            this.Height = (fileInfo.Length / 13 + 1) * 23 + 15;
            int count = 0;
            foreach (FileInfo file in fileInfo)
            {
                Panel pictureBox = new Panel();
                pictureBox.Tag = new Point(count % 13 * 23 + 5, count / 13 * 23 - 25);
                pictureBox.BackgroundImage = Image.FromFile(file.FullName);
                pictureBox.Margin = new System.Windows.Forms.Padding(0);
                pictureBox.Padding = new System.Windows.Forms.Padding(0);
                pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                pictureBox.Width = 23;
                pictureBox.Height = 23;
                pictureBox.Location = new Point(count % 13 * 23, count / 13 * 23);
                pictureBox.MouseHover += new EventHandler(FaceHover);
                pictureBox.MouseLeave += new EventHandler(FaceLeave);
                pictureBox.Click += new EventHandler(pic_Click);
                this.Controls["Face_groupBox"].Controls.Add(pictureBox);
                count++;
            }
            this.isReady = true;
        }

        private void FaceHover(object sender, EventArgs e)
        {
            Panel pic = sender as Panel;
            pic.BorderStyle = BorderStyle.FixedSingle;
            PreView_pictureBox.Image = pic.BackgroundImage;
            Point location = (Point)pic.Tag;
            if (location.Y < -2)
            {
                location.Y = 26;
            }
            PreView_pictureBox.Location = location;
            PreView_pictureBox.Visible = true;
        }

        private void FaceLeave(object sender, EventArgs e)
        {
            Panel pic = sender as Panel;
            pic.BorderStyle = BorderStyle.None;
            PreView_pictureBox.Visible = false;
        }
        private void pic_Click(object sender, EventArgs e)
        {
            if (PicClick != null)
                PicClick(sender, new EventArgs());
            PreView_pictureBox.Visible = false;
        }
    }
}
