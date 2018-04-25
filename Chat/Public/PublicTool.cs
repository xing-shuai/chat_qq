using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Public
{
    public class PublicTool
    {
        /// <summary>
        /// 更新并保存AppConfig配置项
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool UpdateAppConfig(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings[key].Value = value;
                config.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取AppConfig配置项
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppConfig(string key)
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

        /// <summary>
        /// 返回距现在一个时间的表示
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string DateStringFromNow(DateTime time)
        {
            TimeSpan span = DateTime.Now - time;
            if (span.TotalDays > 60)
            {
                return
                time.ToShortDateString();
            }
            else if (span.TotalDays > 30)
            {

                return "1个月前";
            }
            else if (span.TotalDays > 14)
            {
                return "2周前";
            }
            else if (span.TotalDays > 7)
            {
                return "1周前";
            }

            else if (span.TotalDays > 1)
            {
                return string.Format("{0}天前", (int)Math.Floor(span.TotalDays));
            }
            else if (span.TotalHours > 1)
            {
                return string.Format("{0}小时前", (int)Math.Floor(span.TotalHours));
            }
            else if (span.TotalMinutes > 1)
            {
                return string.Format("{0}分钟前", (int)Math.Floor(span.TotalMinutes));
            }
            else if (span.TotalSeconds >= 1)
            {
                return string.Format("{0}秒前",
                (int)Math.Floor(span.TotalSeconds));
            }
            else
            {
                return "1秒前";
            }
        }

        /// <summary>
        /// 获取本地IPv4地址
        /// </summary>
        /// <returns>本地IPv4地址</returns>
        public static IPAddress GetLocalIPv4Address()
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

        /// <summary>
        /// 播放指定音频
        /// </summary>
        /// <param name="soundPath">音频路径</param>
        public static void PlaySound(string soundPath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = soundPath;
                player.Load();//同步加载声音  
                player.Play();//启用新线程播放  
                player.Dispose();
            }
            catch
            { }
        }

        public static String FormatFilesize(double size)
        {
            String[] units = new String[] { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size) + units[i];
        }

        public static Image GetFileTypeImage(string fileExtension)
        {
            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("c", ".c.cs.java.cpp");
            format.Add("CSS", ".css");
            format.Add("doc", ".doc");
            format.Add("excel", ".xls.xlsx");
            format.Add("exe", ".exe");
            format.Add("html", ".htm.html");
            format.Add("MP3", ".mp3.wav");
            format.Add("ppt", ".ppt.pptx");
            format.Add("TXT", ".txt");
            format.Add("zip", ".zip.rar");
            foreach (KeyValuePair<string, string> item in format)
            {
                if (item.Value.Contains(fileExtension))
                {
                    try
                    {
                        return Image.FromFile(@"Resources\img\filetype\" + item.Key + ".png");
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            try
            {
                return Image.FromFile(@"Resources\img\filetype\file.png");
            }
            catch
            {
                return null;
            }
        }
    }
}
