using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Models;
using SearchAPI.Services;

namespace SearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        // GET: api/Search?query=searchterm
        [HttpGet]
        public ActionResult<List<ResultItem>> Get(string query)
        {
            //List<ResultItem> results = new List<ResultItem>();
            //results.Add(new ResultItem() { Heading = "Some first", Link = "www.google.com", Text = "kdakjfs kjksfjk f" });
            //results.Add(new ResultItem() { Heading = "Some second", Link = "www.facebook.com", Text = "lotte jvcjkh f" });

            //return Ok(results);

            return Ok(_searchService.Search(query));

        }
    }
}
