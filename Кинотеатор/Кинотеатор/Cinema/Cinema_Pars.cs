using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Кинотеатор
{
    public class Cinema_Pars
    {
        public List<List_Peremen> Afisha = new List<List_Peremen>();
        public void CinemaParsing()
        {
            
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
                                try
                                {
                                    var text = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[3].ChildNodes[0].InnerText.Trim();
                                    var image = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[1].ChildNodes[1].Attributes["src"].Value;
                                    Afisha.Add(new List_Peremen() { Image = image, name = text });
                                }
                                catch
                                {
                                    var text = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[3].ChildNodes[0].InnerText.Trim();
                                    var image = NewsHtml.ChildNodes[i].ChildNodes[k].ChildNodes[1].ChildNodes[3].Attributes["src"].Value;
                                    Afisha.Add(new List_Peremen() { Image = image, name = text });
                                }
                            }
                        }

                    }
                }
                //foreach (HtmlNode item in NewsHtml.ChildNodes)
                //{


                //    if (item.Name == "li")
                //    {
                //        var image = item.ChildNodes[1].ChildNodes[1].ChildNodes[1];
                //        var text = item.ChildNodes[1].ChildNodes[3].ChildNodes[0].InnerText.Trim();

                //        foreach (HtmlNode item1 in image.ChildNodes)
                //        {
                //            if (item1.Name == "img")
                //            {
                //                var image1 = item1.Attributes["src"].Value;
                //                Afisha.Add(new List_Peremen() { Image = image1, name = text });
                //            }

                //        }
                //    }
                //}


            }
            //col-c

        
    }
    }
    

