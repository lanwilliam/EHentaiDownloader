using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DotNet4.Utilities;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = "https://forums.e-hentai.org/index.php?act=Login&CODE=01",//URL这里都是测试     必需项
                Encoding = null,//编码格式（utf-8,gb2312,gbk）     可选项 默认类会自动识别
                                //Encoding = Encoding.Default,
                Method = "POST",//URL     可选项 默认为Get
                ResultCookieType = ResultCookieType.CookieCollection,
                Postdata = "UserName=lanwilliam&PassWord=016100492"
            };
            //得到HTML代码
            HttpResult result = http.GetHtml(item);

            Console.WriteLine(result.Html);

            CookieCollection cookie = result.CookieCollection;

            item = new HttpItem()
            {
                URL = "https://exhentai.org/g/840899/2d5bb8e073/",//URL这里都是测试URl   必需项
                Encoding = null,//编码格式（utf-8,gb2312,gbk）     可选项 默认类会自动识别
                                //Encoding = Encoding.Default,
                Method = "get",//URL     可选项 默认为Get
                CookieCollection = result.CookieCollection,
                ResultCookieType = ResultCookieType.CookieCollection
            };
            //得到新的HTML代码
            result = http.GetHtml(item);
            Console.WriteLine(result.Html);

            //RedirectPath("https://exhentai.org/");
            Console.Read();
        }

        private static readonly string DefaultUserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";

        public static string RedirectPath(string url)
        {
            StringBuilder sb = new StringBuilder();
            string location = string.Copy(url);
            while (!string.IsNullOrWhiteSpace(location))
            {
                sb.AppendLine(location); // you can also use 'Append'
                HttpWebRequest request = HttpWebRequest.CreateHttp(location);
                request.AllowAutoRedirect = false;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    location = response.GetResponseHeader("Location");
                }
            }
            return sb.ToString();
        }
    }
}
