using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Task4.Models {
   public class Parser:IParser {

        public string searchUrl {get; set;} = "https://www.chipdip.by/search?searchtext=";
        public string currentPage { get; set;} = "&page=";
        HtmlDocument htmlDocument = new HtmlDocument();
        HttpClient httpClient = new HttpClient();
        
        public List<HtmlNode> GetHtml(List<HtmlNode> List,string tag,string attribute,string val,int k)
        {
            
            return List[k].Descendants(tag)
            .Where(x=>x.GetAttributeValue(attribute,"")
            .Equals(val)).ToList();
        }
        public async Task<IEnumerable<Table>> GetStringDoc(string url)
        {         
            var items = new List<Table> {};
            int lastPage=10;
            try {
                for (int j = 0; j<lastPage;j++)
                {
                    var html = await httpClient.GetStringAsync(searchUrl+url+currentPage+j.ToString());  
                    htmlDocument.LoadHtml(html);
                
                    lastPage = htmlDocument.DocumentNode.Descendants("li")
                        .Where(x => x.GetAttributeValue("class", "")
                        .Contains("pager__page")).ToList().Count;

                    var productHtml = htmlDocument.DocumentNode.Descendants("tr")
                        .Where(x => x.GetAttributeValue("class", "")
                        .Contains("with-hover")).ToList();
                    for (int i = 0; i< productHtml.Count;i++)
                    {   
                        var productLink = GetHtml(productHtml,"a","class", "link",i);              
                        var productImg = GetHtml(productHtml,"img","class","img75",i);
                        
                        if(productLink.Count!=0&&productImg.Count!=0)
                        {
                            int ind = productLink[0].OuterHtml.Trim('\r','\n','\t').IndexOf(">");
                            int index = productImg[0].OuterHtml.Trim('\r','\n','\t').IndexOf("jpg");
                            

                            Table table = new Table {
                                Href = productLink[0].OuterHtml.Trim('\r','\n','\t').Substring(23,ind-24),
                                Img = productImg[0].OuterHtml.Trim('\r','\n','\t').Substring(10,index-7),
                                HrefText = productLink[0].InnerText.Trim('\r','\n','\t')
                        };
                        
                        items.Add(table);
                        }
                    }            
                }
                return  items;
            }
            catch(Exception ex ){
                return  items;
            }
        }

    }
}