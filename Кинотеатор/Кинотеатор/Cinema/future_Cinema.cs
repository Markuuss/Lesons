using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Кинотеатор
{
    class Future_Cinema
    {
        public List<List_Peremen> Futurre = new List<List_Peremen>();
        public void LoadingFutureCinema()
        {
            for (int j = 0; j < 20; j++)
            {
                HttpWebRequest NewsPars;
                HttpWebResponse response;
                HtmlDocument htmlDocument = new HtmlDocument();
                string url = "https://afisha.tut.by/film/";
                NewsPars = (HttpWebRequest)WebRequest.Create(url);
                response = (HttpWebResponse)NewsPars.GetResponse();
                htmlDocument.Load(response.GetResponseStream(), Encoding.UTF8);

                var NewsHtml = htmlDocument.DocumentNode.Descendants("div").FirstOrDefault(x => x.Attributes.Contains("class") && x.Attributes["class"].Value == "events-block js-cut_wrapper");
                for (int f = 0; f < NewsHtml.ChildNodes.Count; f++)
                {
                    if (NewsHtml.ChildNodes[f].Name == "div")
                    {
                        for (int i = 0; i < NewsHtml.ChildNodes[f].ChildNodes.Count; i++)
                        {
                            if (NewsHtml.ChildNodes[i].Name == "ul")
                            {
                                for (int k = 0; k < NewsHtml.ChildNodes[i].ChildNodes.Count; k++)
                                {
                                    if (NewsHtml.ChildNodes[f].ChildNodes[i].ChildNodes[k].Name == "li")
                                    {
                                        var image = NewsHtml.ChildNodes[f].ChildNodes[i].ChildNodes[k].ChildNodes[1].ChildNodes[1].Attributes["src"].Value;
                                        var text = NewsHtml.ChildNodes[f].ChildNodes[i].ChildNodes[k].ChildNodes[3].ChildNodes[0].InnerText.Trim();


                                        Futurre.Add(new List_Peremen() { });
                                    }
                                }

                            }
                        }
                    }
                }

            }
        }
    }
}

