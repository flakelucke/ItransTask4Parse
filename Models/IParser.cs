using System.Collections.Generic;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Task4.Models {
    public interface IParser
    {
        Task<IEnumerable<Table>> GetStringDoc();
    }
}