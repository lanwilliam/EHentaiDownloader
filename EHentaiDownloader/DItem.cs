using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HtmlAgilityPack;
using System.IO;

namespace EHentaiDownloader
{
    public partial class DItem : UserControl
    {
        SynchronizationContext m_SyncContext = null;

        public bool IsCancel
        {
            set;get;
        }

        public DItem(string url)
        {
            dInfo = new DInfo();
            dInfo.URL = url;
            
            //获取UI线程同步上下文
            m_SyncContext = SynchronizationContext.Current;

            InitializeComponent();
            lbURL.Text = url;
            IsCancel = false;
        }

        public DItem(DInfo info)
        {
            this.dInfo = info;
            //获取UI线程同步上下文
            m_SyncContext = SynchronizationContext.Current;

            InitializeComponent();
            lbURL.Text = info.URL;
            lbTitle.Text = info.Title;
            lbStatus.Text = "waiting";
            lbProgress.Text = info.Current+"/"+info.CNT;
            IsCancel = false;
        }


        string filePath = Application.StartupPath + "\\Download";
        string SavePath = "";
        public DInfo dInfo = null;

        private WebHelper helper = new WebHelper();

        

        #region 设置Label

        private void SetCurrent(object cur)
        {
            dInfo.Current = (int)cur;
        }

        public void SetNo(int no)
        {
            lbNo.Text = no.ToString("000");
        }

        private void SetTitle(object text)
        {
            this.lbTitle.Text = text.ToString();
        }

        private void SetStatus(object text)
        {
            if (text.ToString().Equals("finished"))
            {
                this.BackColor = Color.LightGreen;
            }
            else if (text.ToString().Contains("Error"))
            {
                this.BackColor = Color.LightPink;
            }
            else if (text.ToString().Contains("running"))
            {
                this.BackColor = Color.LightSkyBlue;
            }
            else if(text.ToString().Equals("waiting"))
            {
                this.BackColor = SystemColors.Control;
            }
            this.lbStatus.Text = text.ToString();
        }
        private void SetURL(object text)
        {
            this.lbURL.Text = text.ToString();
        }
        private void SetProgress(object text)
        {
            
            this.lbProgress.Text = text.ToString();
        }
        
        public string Status
        {
            get { return this.lbStatus.Text; }
        }
        #endregion

        private string RelpaceFileName(string file)
        {
            file = file.Replace("?", "");
            file = file.Replace("/", "");
            file = file.Replace("\\", "");
            file = file.Replace("<", "");
            file = file.Replace(">", "");
            file = file.Replace("|", "");
            file = file.Replace("*", "");
            file = file.Replace("\"", "");
            return file;
        }

        string html = "";
        public void Run(object obj)
        {
            if(IsCancel)
            {
                return;
            }
            try
            {
                #region Run

                // 设置Status
                m_SyncContext.Post(SetStatus, "running");

                string url = dInfo.URL;
                html = helper.GetHTML(url);
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(html);

                HtmlNode rootNode = document.DocumentNode;
                HtmlNode tt = rootNode.SelectSingleNode("//*[@id=\"gn\"]");

                HtmlNode titleNode = rootNode.SelectSingleNode("//*[@id=\"gj\"]");

                string title = string.IsNullOrEmpty(titleNode.InnerText) ? tt.InnerText : titleNode.InnerText;

                title = title.Replace(":", "").Replace("?", "").Replace("*", "");
                SavePath = filePath + "\\" + RelpaceFileName(title);
                if (!Directory.Exists(SavePath))
                    Directory.CreateDirectory(SavePath);

                // 设置TItle
                m_SyncContext.Post(SetTitle, title);
                dInfo.Title = titleNode.InnerText;

                HtmlNodeCollection imgColl = rootNode.SelectNodes("//*[@id=\"gdt\"]/div");
                List<HtmlNode> imglist = imgColl.ToList();

                HtmlNodeCollection pageList = rootNode.SelectNodes("//*[@class=\"ptb\"]/*/td");

                HtmlNode last = pageList.Last();
                if (last.InnerHtml != "&gt;")
                {
                    string purl = last.ChildNodes[0].Attributes["href"].Value;
                    GetImageList(imglist, purl);
                }
                

                //HtmlNodeCollection pageList = rootNode.SelectNodes("//*[@class=\"ptb\"]/*/td");
                //while(true)
                //{
                //    HtmlNode last = pageList.Last();
                //    if(last.InnerHtml== ">")
                //    {
                //        break;
                //    }

                //    string purl = pageList.Last().ChildNodes[0].Attributes["href"].Value;
                //    string phtml = helper.GetHTML(purl);

                //}

                dInfo.CNT = imglist.Count;
                // 如果新开始的，Current=0，如果重新加载的，那么Current不为0的话，不重置
                if (dInfo.Current == 0)
                    dInfo.Current = 1;

                int i = 1;



                foreach (HtmlNode node in imglist)
                {
                    try
                    {
                        #region image
                        // 设置Status
                        m_SyncContext.Post(SetProgress, dInfo.Current + "/" + dInfo.CNT);
                        if (node.Attributes["class"].Value != "gdtm")
                        {
                            i++;
                            continue;
                        }
                            
                        if (i < dInfo.Current)
                        {
                            i++;
                            continue;
                        }
                        string imgUrl = node.ChildNodes[0].FirstChild.Attributes[0].Value;
                        string DetailHTML = helper.GetHTML(imgUrl);

                        HtmlAgilityPack.HtmlDocument imgDoc = new HtmlAgilityPack.HtmlDocument();
                        imgDoc.LoadHtml(DetailHTML);
                        string iurl = imgDoc.DocumentNode.SelectSingleNode("//*[@id=\"img\"]").Attributes["src"].Value;
                        string hz = iurl.Substring(iurl.Length - 4, 4);
                        string filePath = SavePath + "\\" + i.ToString("000") + hz;
                        try
                        {
                            helper.DownLoadImage(iurl, filePath);
                            FileInfo info = new FileInfo(filePath);
                            if(info.Length== 28658)
                            {
                                m_SyncContext.Post(SetStatus, "Limit Error");
                                info.Delete();
                                return;

                            }
                            //Image img = Image.FromFile(filePath);
                        }
                        catch (Exception e)
                        {
                            Log(dInfo.URL, e.Message);
                            m_SyncContext.Post(SetStatus, "Error");
                            return;
                        }
                        i++;
                        dInfo.Current = i;
                        //*[@id="gdt"]/div[1]/div/a
                        #endregion
                    }
                    catch (Exception e)
                    {
                        Log(dInfo.URL, e.Message);
                        m_SyncContext.Post(SetStatus, "Error");
                        return;
                    }
                    
                }
                // 设置Status
                m_SyncContext.Post(SetStatus, "finished");
                #endregion
            }
            catch(Exception e)
            {
                // 设置Status
                m_SyncContext.Post(SetStatus, "Error");
                Log(dInfo.URL, e.Message);
                Log(dInfo.URL, html);
            }

        }

        private void Log(string title ,string mess)
        {
            if(!Directory.Exists("log"))
            {
                Directory.CreateDirectory("log");
            }
            StreamWriter sw = new StreamWriter("log/" + title.Replace("/","").Replace("?nw=session", "").Replace(":","")+".txt",true);
            sw.WriteLine("******************");
            sw.WriteLine("DateTime:" + DateTime.Now.ToString());
            sw.WriteLine("Message:" + mess);
            sw.WriteLine("******************");
            sw.Close();
        }

        private void GetImageList(List<HtmlNode> rlist ,string url)
        {
            string html = helper.GetHTML(url);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);

            HtmlNode rootNode = document.DocumentNode;
            HtmlNode titleNode = rootNode.SelectSingleNode("//*[@id=\"gj\"]");
            
            HtmlNodeCollection imglist = rootNode.SelectNodes("//*[@id=\"gdt\"]/div");

            rlist.AddRange(imglist.ToList());

            HtmlNodeCollection pageList = rootNode.SelectNodes("//*[@class=\"ptb\"]/*/td");

            
            HtmlNode last = pageList.Last();
            if (last.InnerHtml == "&gt;")
            {
                return;
            }

            string purl = pageList.Last().ChildNodes[0].Attributes["href"].Value;

            GetImageList(rlist, purl);
        }

        private void 复制下载链接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(dInfo.URL);
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", SavePath);
        }

        private void 重新尝试ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReStart();
        }

        public void ReStart()
        {
            // 设置Status
            m_SyncContext.Post(SetStatus, "waiting");
            ThreadManager.ReStart(this);
        }

        private void 设置开始位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int cur = int.Parse(tbCurrent.Text);
                dInfo.Current = cur;
                lbProgress.Text = dInfo.Current + "/" + dInfo.CNT;
                //MessageBox.Show(lbProgress.Text);
                //m_SyncContext.Post(SetCurrent, cur);
                //m_SyncContext.Post(SetProgress, dInfo.Current + "/" + dInfo.CNT);
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                panel1.Visible = false;
            }
        }

        private void 移除任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsCancel = true;
            ((Form1)Form1.ActiveForm).RemoveTask(this);
        }
    }
}
