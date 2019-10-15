using System.Collections.Generic;
using HtmlAgilityPack;
using SearchAPI.Models;

namespace SearchAPI.Services
{
    public class GoogleSearchService : ISearchService
    {
        private string _baseSearchURL = "https://google.com/search?q=";
        private HtmlWeb _website;

        public GoogleSearchService()
        {
            _website = new HtmlWeb();
        }

        public List<ResultItem> Search(string query)
        {
            string SearchURL = $"{_baseSearchURL}{query}";
            var document = _website.Load(SearchURL);

            List<ResultItem> Results = ExtractResults(document);

            return Results;
        }

        private List<ResultItem> ExtractResults(HtmlDocument document)
        {
            List<ResultItem> GResults = new List<ResultItem>();

            HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(".r");
            foreach (HtmlNode node in nodes)
            {
                GResults.Add(new ResultItem() { Heading = node.SelectNodes(".LC20lb")[0].InnerText, Link = node.SelectNodes(".bc")[0].InnerText });
            }

            nodes = document.DocumentNode.SelectNodes(".st");
            for (int i = 0; i < nodes.Count; i++)
            {
                GResults[i].Text = nodes[i].InnerText;
            }

            return GResults;
        }
    }
}
