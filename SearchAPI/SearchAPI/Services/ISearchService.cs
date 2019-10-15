using SearchAPI.Models;
using System.Collections.Generic;

namespace SearchAPI.Services
{
    public interface ISearchService
    {
        List<ResultItem> Search(string query);
    }
}