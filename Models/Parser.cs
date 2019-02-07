using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Task4.Models {
   public class Parser:IParser {

        public string searchUrl {get; set;} = "https://www.chipdip.by/search?searchtext=кая";
        HtmlDocument htmlDocument = new HtmlDocument();
        HttpClient httpClient = new HttpClient();
        
        public async Task<IEnumerable<Table>> GetStringDoc()
        {
            var html = await httpClient.GetStringAsync(searchUrl);         
            htmlDocument.LoadHtml(html);
            var productHtml = htmlDocument.DocumentNode.Descendants("table")
                .Where(x => x.GetAttributeValue("id", "")
                .Equals("itemlist")).ToList();
            
            var productList = productHtml[0].Descendants("tr")
                .Where(node => node.GetAttributeValue("class","")
                .Contains("with-hover")).ToList();
            
            var items = new List<Table> {};
            foreach (var item in productList)
            {
                Table table = new Table();
                table.Href = item.InnerHtml.Trim('\r','\n','\t');
                items.Add(table);
            }
            return  items.ToList();
        }

    }
}