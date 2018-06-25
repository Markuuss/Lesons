using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Кинотеатор
{
    public class Pars_opisan
    {
        public List<Peremen_opisanie> Opisa = new List<Peremen_opisanie>();

        public void Opisan()
        {
            Peremen_opisanie peremen_Opisanie = new Peremen_opisanie();
            HttpWebRequest NewsPars;
            HttpWebResponse response;
            HtmlDocument htmlDocument = new HtmlDocument();
            string url = "https://afisha.tut.by/film/";
            NewsPars = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)NewsPars.GetResponse();
            htmlDocument.Load(response.GetResponseStream(), Encoding.UTF8);
            var NewsHtml = htmlDocument.DocumentNode.Descendants("div").FirstOrDefault(x => x.Attributes.Contains("class") && x.Attributes["class"].Value == "events-block js-cut_wrapper");
            for (int i = 0; i < NewsHtml.ChildNodes.Count; i++)
            {
                if (NewsHtml.ChildNodes[i].Name == "ul")
                {
                    for (int k = 0; k < NewsHtml.ChildNodes[i].ChildNodes.Count; k++)
                    { 
                        if (NewsHtml.ChildNodes[i].ChildNodes[k].Name == "li")
                        {
                            for (int j = 0; j < NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes.Count; j++)
                            {
                                if (NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[j].Name == "div")
                                {
                                    try
                                    {
                                        string opisanie = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[j].ChildNodes[1].InnerText.Trim();
                                       opisanie=opisanie.Replace("&nbsp;", " ");
                                        Opisa.Add(new Peremen_opisanie() { Opisanie = opisanie });
                                    }
                                    catch
                                    {
                                        string opisanie = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[j].ChildNodes[1].InnerText.Trim();
                                        opisanie=opisanie.Replace("&nbsp;"," ");
                                        Opisa.Add(new Peremen_opisanie() { Opisanie = opisanie });
                                        
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
