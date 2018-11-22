using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace EHentaiDownloader
{
    public partial class Form1 : Form
    {
        string filePath = Application.StartupPath + "\\Download";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbURL.Text == "")
                return;
            string url = tbURL.Text+ "?nw=session";

            AddTask(url);
            //DItem item = new DItem(url);
            //item.Width = this.flowLayoutPanel1.Width - 10;
            //this.flowLayoutPanel1.Controls.Add(item);
            //ThreadManager.AddTask(item);

            tbURL.Text = "";
        }

        private void AddTask(string url)
        {

            DItem item = new DItem(url);
            item.Width = this.flowLayoutPanel1.Width - 25;
            this.flowLayoutPanel1.Controls.Add(item);
            ThreadManager.AddTask(item);
        }

        private void AddTask(DItem item)
        {
            item.Width = this.flowLayoutPanel1.Width - 25;
            this.flowLayoutPanel1.Controls.Add(item);
            ThreadManager.AddTask(item);
        }


        private void DownLoadImage(string url, string path)
        {

            WebClient mywebclient = new WebClient();
            mywebclient.DownloadFile(url, path);
        }



        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.flowLayoutPanel1.Controls)
            {
                if (ctrl.GetType() == typeof(DItem))
                {
                    ctrl.Width = this.flowLayoutPanel1.Width - 25;
                }
            }
        }

        private void 说明ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void 导入任务记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("会覆盖原任务记录文件，现在去备份还来得及，确定后就完了，请注意！");
            StreamWriter fs = new StreamWriter("任务记录.txt", false, Encoding.UTF8);
            foreach (DItem item in ThreadManager.list)
            {
                fs.WriteLine("------------------------------------------------");
                fs.WriteLine("URL:" + item.dInfo.URL);
                fs.WriteLine("Title:" + item.dInfo.Title);
                fs.WriteLine("Progress:" + item.dInfo.Current + "/" + item.dInfo.CNT);
                fs.WriteLine("Status:" + item.Status);
                fs.WriteLine("------------------------------------------------");
            }
            fs.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            tbURL.Focus();
            this.flowLayoutPanel1.Update();
        }

        private void 导入任务记录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("导入任务记录会将任务记录数据全部重新下载，用来处理Ehentai，每日限量导致错误。");

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            StreamReader reader = new StreamReader(filename);
            while (true)
            {
                string line = reader.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    MessageBox.Show("Load completed！");
                    break;
                }

                string l1 = line;
                string url = reader.ReadLine();
                string title = reader.ReadLine();
                string progress = reader.ReadLine();
                string status = reader.ReadLine();
                string l2 = reader.ReadLine();

                //if (!line.StartsWith("URL:"))
                //{
                //    continue;
                //}

                url = url.Replace("URL:", "");
                title = title.Replace("Title:", "");
                progress = progress.Replace("Progress:", "");
                bool needImp = status.Contains("Error")|| status.Contains("running")|| status.Contains("waiting");
                if (!needImp)
                    continue;
                DInfo info = new DInfo();
                info.URL = url;
                info.Title = title;
                info.Current = int.Parse(progress.Substring(0, progress.IndexOf("/")));
                if (info.Current > 1)
                {
                    info.Current--;
                }
                info.CNT = int.Parse(progress.Substring(progress.IndexOf("/") + 1));
                DItem item = new DItem(info);

                AddTask(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebHelper helper = new WebHelper();
            try
            {
                // 使用E绅士账号登录，据说可以增加下载图片数量。
                helper.Login();
            }catch(Exception ex)
            {
                MessageBox.Show("登录错误。错误信息：" + ex.Message);
            }
            

        }

        bool isShow = true;
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isShow)
            {
                this.Hide();
                isShow = false;
            }
            else
            {
                this.Show();
                isShow = true;
            }

        }

        private void 导入全部任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            StreamReader reader = new StreamReader(filename);
            while (true)
            {
                string line = reader.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    MessageBox.Show("Load completed！");
                    break;
                }

                string l1 = line;
                string url = reader.ReadLine();
                string title = reader.ReadLine();
                string progress = reader.ReadLine();
                string status = reader.ReadLine();
                string l2 = reader.ReadLine();

                url = url.Replace("URL:", "");
                title = title.Replace("Title:", "");
                progress = progress.Replace("Progress:", "");

                //// 总记录为零 说明下载错误
                //if(progress.Substring(progress.IndexOf("/") + 1)=="0")
                //{
                //    continue;
                //}
                DInfo info = new DInfo();
                info.URL = url;
                info.Title = title;
                info.Current = int.Parse(progress.Substring(0, progress.IndexOf("/")));
                
                if (status.Contains("Limit Error") &&info.Current > 1)
                {
                    info.Current--;
                }

                info.CNT = int.Parse(progress.Substring(progress.IndexOf("/") + 1));

                //if (!line.StartsWith("URL:"))
                //{
                //    continue;
                //}

                url = url.Replace("URL:", "");

                DItem item = new DItem(info);

                AddTask(item);
            }
        }

        private void 打开下载目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", filePath);
        }

        private void 移除已完成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DItem> list = ThreadManager.GetFinishedList();
            foreach(DItem item in list)
            {
                this.flowLayoutPanel1.Controls.Remove(item);
            }
            ThreadManager.FlushNo();
        }

        private void 移除ErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DItem> list = ThreadManager.GetErrorList();
            foreach (DItem item in list)
            {
                this.flowLayoutPanel1.Controls.Remove(item);
            }
            ThreadManager.FlushNo();
        }

        private void 重启Error任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DItem> list = ThreadManager.GetErrorList2();
            foreach (DItem item in list)
            {
                item.ReStart();
            }
        }
        
        public void RemoveTask(DItem item)
        {
            this.flowLayoutPanel1.Controls.Remove(item);
            ThreadManager.Remove(item);
            ThreadManager.FlushNo();
        }

        private void 导出未完成任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DItem> list = ThreadManager.GetErrorList2();

            MessageBox.Show("会覆盖原任务记录文件，现在去备份还来得及，确定后就完了，请注意！");
            StreamWriter fs = new StreamWriter("任务记录.txt", false, Encoding.UTF8);
            foreach (DItem item in list)
            {
                fs.WriteLine("------------------------------------------------");
                fs.WriteLine("URL:" + item.dInfo.URL);
                fs.WriteLine("Title:" + item.dInfo.Title);
                fs.WriteLine("Progress:" + item.dInfo.Current + "/" + item.dInfo.CNT);
                fs.WriteLine("Status:" + item.Status);
                fs.WriteLine("------------------------------------------------");
            }
            fs.Close();
        }
    }
}
