using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applause
{
    public class PagedResult<T>
    {
        public List<T> Results { get; set; } = new List<T>();
        public string PageIdentifier { get; set; }
        public int PageSize { get; set; }

    }
}
