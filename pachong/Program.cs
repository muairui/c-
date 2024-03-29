﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pachong
{
    class Program
    {
        static void Main(string[] args)
        {
            var crawler = new Crawler("https://blog.csdn.net/u011110982/article/details/79297790");
            crawler.DownLoad();
            foreach(var item in Crawler.visited)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }

    public class Crawler
    {
        public static Uri baseUri;
        public static string baseHost = string.Empty;

        /// <summary>
        /// 工作队列
        /// </summary>
        public static Queue<string> todo = new Queue<string>();
        /// <summary>
        /// 以访问队列
        /// </summary>
        public static HashSet<string> visited = new HashSet<string>();

        public Crawler(string url)
        {
            baseUri = new Uri(url);
            //基域
            baseHost = baseUri.Host.Substring(baseUri.Host.IndexOf('.'));
            //抓取首地址入队
            todo.Enqueue(url);
        }

        public void DownLoad()
        {
            while(todo.Count>0)
            {
                var currentUrl = todo.Dequeue();
                //当前url标记为已访问过
                visited.Add(currentUrl);
                var request = WebRequest.Create(currentUrl) as HttpWebRequest;

                var response = request.GetResponse() as HttpWebResponse;

                var sr = new StreamReader(response.GetResponseStream());
                //提取url，将未访问的放入todo表中
                RefineUrl(sr.ReadToEnd());

                if (todo.Count > 10000)
                    break;
            
            }
        }
        /// <summary>
        /// 提取Url
        /// </summary>
        /// <param name="html"></param>
        public void RefineUrl(string html)
        {
            Regex reg = new Regex(@"(?is)<a[^>]*?href=(['""]?)(?<url>[^'""\s>]+)\1[^>]*>(?<text>(?:(?!</?a\b).)*)</a>");
            MatchCollection mc = reg.Matches(html);
            foreach(Match m in mc)
            {
                var url = m.Groups["url"].Value;
                if (url == "#")
                    continue;
                //相对路径转换为绝对路径
                Uri uri = new Uri(baseUri, url);
                //剔除外网链接(获取顶级域名)
                if (!uri.Host.EndsWith(baseHost))
                    continue;
                if(!visited.Contains(uri.ToString()))
                {
                    todo.Enqueue(uri.ToString());
                }
            }
        }
    }
}
