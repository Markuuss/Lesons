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
            //col-c
            HttpWebRequest NewsPars;
            HttpWebResponse response;
            HtmlDocument htmlDocument = new HtmlDocument();
            string url = "http://kinominska.by";
            NewsPars = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)NewsPars.GetResponse();
            htmlDocument.Load(response.GetResponseStream(), Encoding.GetEncoding("windows-1251"));

            var NewsHtml = htmlDocument.DocumentNode.Descendants("div").FirstOrDefault(x => x.Attributes.Contains("class") && x.Attributes["class"].Value == "jcarousel-clip jcarousel-clip-horizontal");
            foreach (HtmlNode item in NewsHtml.ChildNodes)
            {
                if (item.Name == "ul")
                {
                    var image = item.ChildNodes[1].ChildNodes[1].FirstChild.Attributes["src"].Value;
                    //var text = item.ChildNodes[7].ChildNodes[1].InnerText.Trim();
                    Afisha.Add(new List_Peremen() { Image = image, /*TextNew=text*/});
                }
            }
        }
    }
}
