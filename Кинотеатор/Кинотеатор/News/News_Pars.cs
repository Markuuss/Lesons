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
                string url = "https://afisha.tut.by";
                NewsPars = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)NewsPars.GetResponse();
                htmlDocument.Load(response.GetResponseStream(), Encoding.UTF8);

                var NewsHtml = htmlDocument.DocumentNode.Descendants("div").FirstOrDefault(x => x.Attributes.Contains("class") && x.Attributes["class"].Value == "inner grid b-news");
                for (int i = 0; i < NewsHtml.ChildNodes.Count; i++)
                {
                    if (NewsHtml.ChildNodes[i].Name == "ul")
                    {
                        for (int k = 0; k < NewsHtml.ChildNodes[i].ChildNodes.Count; k++)
                        {
                            if (NewsHtml.ChildNodes[i].ChildNodes[k].Name == "li")
                            {
                                var image = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[1].ChildNodes[1].Attributes["src"].Value;
                                var text = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[3].InnerText.Trim();

                                //foreach (HtmlNode item1 in NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes)
                                //{
                                //    if (item1.Name == "img")
                                //    {
                                //        var image1 = item1.Attributes["src"].Value;
                                //        Afisha.Add(new List_Peremen() { Image = image1, name = text });
                                //    }

                                //}
                                data.Add(new Peremen() { Image = image,TextNew=text });
                            }
                        }

                    }
                }
                //foreach (HtmlNode item in NewsHtml.ChildNodes)
                //{
                //    if (item.Name == "ul")
                //    {
                //        var image = item.ChildNodes[1].ChildNodes[1].ChildNodes[1].FirstChild.Attributes["src"].Value;
                //        var zagolov = item.ChildNodes[1].ChildNodes[1].FirstChild.Attributes["alt"].Value;
                //        var text = item.ChildNodes[7].ChildNodes[1].InnerText.Trim();
                //        data.Add(new Peremen() { Image = image, /*TextNew=text*/Zagolovok = zagolov });
                //    }
                //}
            }
            catch (WebException)
            {
                if (MessageBox.Show("Нет подключения к интернету") == MessageBoxResult.OK)
                {

                }
                Environment.Exit(0);
            }
        
        }
        
    
    }
    
}
