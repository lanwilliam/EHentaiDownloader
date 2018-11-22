using MihaZupan;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Configuration;

namespace EHentaiDownloader
{
    public class WebHelper
    {

        public void DownLoadImage(string url, string path)
        {

            CookieAwareWebClient mywebclient = new CookieAwareWebClient(cookie);
            mywebclient.Timeout = 20000;
            mywebclient.DownloadFile(url, path);
        }

        public string GetHTML(string url)

        {

            try
            {

                CookieAwareWebClient MyWebClient = new CookieAwareWebClient(cookie);

                MyWebClient.Headers.Add("Cookie", _cookies);
                MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据

                Byte[] pageData = MyWebClient.DownloadData(url); //从指定网站下载数据

                string pageHtml = Encoding.UTF8.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句            

                return pageHtml;

            }

            catch (WebException webEx)
            {

                Console.WriteLine(webEx.Message.ToString());
                return null;
            }

        }
        
        public string Login()
        {
            //delete();
            using (var client = new CookieAwareWebClient(cookie))
            {
                var values = new NameValueCollection();
                values["UserName"] = ConfigurationManager.AppSettings["name"];
                values["PassWord"] = ConfigurationManager.AppSettings["pass"];

                var response = client.UploadValues("https://forums.e-hentai.org/index.php?act=Login&CODE=01", values);

                _cookies = client.ResponseHeaders["Set-Cookie"];
                var responseString = Encoding.Default.GetString(response);
                //client.DownloadData("https://exhentai.org");

                return responseString;
            }
            
        }

        public static CookieContainer cookie = new CookieContainer();
        private static string _cookies = string.Empty;
        public static string header = "";
        public static bool login = false;
        private class CookieAwareWebClient : WebClient
        {
            public int Timeout { get; set; }

            public CookieAwareWebClient()
                : this(new CookieContainer())
            {
                Timeout = 10000;
            }
            public CookieAwareWebClient(CookieContainer c)
            {
                this.CookieContainer = c;
                Timeout = 10000;
                // 增加Socks5Proxy支持
                //var proxy = new HttpToSocks5Proxy("5.135.104.158", 8080);
                //this.Proxy = proxy;

            }
            public CookieContainer CookieContainer { get; set; }

            protected override WebRequest GetWebRequest(Uri address)
            {
                WebRequest request = base.GetWebRequest(address);

                request.Timeout = Timeout;
                //request.Headers.Set(HttpRequestHeader.Cookie, header);
                if (request is HttpWebRequest)
                {
                    (request as HttpWebRequest).UserAgent ="Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
                    (request as HttpWebRequest).CookieContainer = this.CookieContainer;
                    //(request as HttpWebRequest).AllowAutoRedirect = false;
                }
                return request;
            }

            protected override WebResponse GetWebResponse(WebRequest request)
            {
                try
                {
                    
                    WebResponse rsp = base.GetWebResponse(request);
                    if (!string.IsNullOrEmpty(rsp.Headers[HttpResponseHeader.SetCookie]))
                        header = rsp.Headers[HttpResponseHeader.SetCookie];

                    return rsp;
                }catch(Exception e)
                {
                    return null;
                }
                
            }
        }

        //获取IE临时文件
        private void delete()
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            //遍历所有的文件夹 显示.dat的文件
            foreach (FileInfo file in dir.GetFiles("*.dat", SearchOption.AllDirectories))
            {
                file.Delete();
            }
        }

    }
}
