using HtmlAgilityPack;
using ScrapySharp.Extensions;
using SearchAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SearchAPI.Services
{
    public class YahooSearchService : ISearchService
    {
        private string _baseSearchURL = "https://in.search.yahoo.com/search?p=";
        private HtmlWeb _website;

        public YahooSearchService()
        {
            _website = new HtmlWeb();
        }

        public List<ResultItem> Search(string query)
        {
            string SearchURL = $"{_baseSearchURL}{query}";
            HtmlDocument document = _website.Load(@SearchURL);

            List<ResultItem> Results = ExtractResults(document);

            return Results;
        }

        private List<ResultItem> ExtractResults(HtmlDocument document)
        {
            List<ResultItem> GResults = new List<ResultItem>();

            var nodes = document.DocumentNode.CssSelect(".options-toggle").ToList();
            foreach (var node in nodes)
                GResults.Add(new ResultItem() { Heading = node.CssSelect(".lh-24").Single().InnerText, Link = node.CssSelect(".lh-17").Single().InnerText });

            nodes = document.DocumentNode.CssSelect(".lh-16").ToList();
            for (int i = 0; i < nodes.Count && i < GResults.Count; i++)
                GResults[i].Text = nodes[i].InnerText;

            return GResults;
        }
    }
}
