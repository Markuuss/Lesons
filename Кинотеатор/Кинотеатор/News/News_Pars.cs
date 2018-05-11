using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace Кинотеатор
{
    public class News_Pars
    {
        public List<Peremen> data = new List<Peremen>();
        public void UpDateAdapter()
        {
            try
            {
                HttpWebRequest NewsPars;
                HttpWebResponse response;
                HtmlDocument htmlDocument = new HtmlDocument();
                string url = "https://www.kinopoisk.ru";
                NewsPars = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)NewsPars.GetResponse();
                htmlDocument.Load(response.GetResponseStream(), Encoding.GetEncoding("windows-1251"));

                var NewsHtml = htmlDocument.DocumentNode.Descendants("div").FirstOrDefault(x => x.Attributes.Contains("class") && x.Attributes["class"].Value == "newsList newsList_main");
                foreach (HtmlNode item in NewsHtml.ChildNodes)
                {
                    if (item.Name == "div")
                    {
                        var image = item.ChildNodes[1].ChildNodes[1].FirstChild.Attributes["src"].Value;
                        var zagolov = item.ChildNodes[1].ChildNodes[1].FirstChild.Attributes["alt"].Value;
                        //var text = item.ChildNodes[7].ChildNodes[1].InnerText.Trim();
                        data.Add(new Peremen() { Image = image, /*TextNew=text*/Zagolovok = zagolov });
                    }
                }
            }
            catch (WebException)
            {
                if (MessageBox.Show("Нет подключене к интернету") == MessageBoxResult.OK)
                {

                }
                Environment.Exit(0);
            }
        
        }
        
    
    }
    
}
