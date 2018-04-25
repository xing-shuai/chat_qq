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
using Chat.Public;

namespace Chat.CustomControl
{
    public partial class FileUpLoad : UserControl
    {
        public FileUpLoad()
        {
            InitializeComponent();
        }

        public bool isReady = false;

        public string filePath = String.Empty;

        private void Option_button_Click(object sender, EventArgs e)
        {
            Option_contextMenuStrip.Show(Cursor.Position);
            //Option_contextMenuStrip.Tag = this.filePath;
        }

        private void OpenFile_button_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("该文件不存在", "操作提示");
                return;
            }
            System.Diagnostics.Process.Start(filePath);
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = filePath.Substring(0, filePath.LastIndexOf('\\'));
            if (!System.IO.Directory.Exists(folderPath))
            {
                MessageBox.Show("文件夹不存在", "操作提示");
                return;
            }
            System.Diagnostics.Process.Start(folderPath);
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isReady)
            {
                SaveFile_saveFileDialog.FileName = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                SaveFile_saveFileDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("文件正在传输，请稍候操作。", "操作提示");
            }
        }

        public void Init(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                return;
            }
            this.filePath = filePath;
            FileInfo file = new FileInfo(filePath);
            FileName_label.Text = file.Name;
            FileType_label.Text = file.Extension;
            FileSize_label.Text = PublicTool.FormatFilesize(file.Length);
            FileTypeImg_panel.BackgroundImage = PublicTool.GetFileTypeImage(file.Extension);
        }

        private void 转发ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中...", "操作提示");
        }

        private void SaveFile_saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string sourceFile = this.filePath;
            string destinationFile = SaveFile_saveFileDialog.FileName;
            FileInfo file = new FileInfo(sourceFile);
            if (file.Exists)
            {
                file.CopyTo(destinationFile, false);
            }
        }
    }
}
