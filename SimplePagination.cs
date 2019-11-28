using Microsoft.Extensions.Caching.Memory;
using System;
using System.Net;
using static Tavisca.Applause.Constant;

namespace Tavisca.Applause
{
    public class SimplePagination : IPagination
    {
        private IMemoryCache _cache;

        public string identifier;
        public string pageState;
        public int pageSize;

        public SimplePagination(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void SetPaginationState(string identifier, int pageSize)
        {
            this.pageSize = pageSize;
            this.identifier = identifier;
            if (identifier != null)
            {
                TryGetPageStateFromCache(identifier);
            }
            else
            {
                pageState = null;
            }
        }

        public string SavePageState(string pageState, int count)
        {
            if (pageState == null)
                return null;
            this.pageState = pageState;
            if (count < pageSize)
            {
                pageSize = count;
                identifier = null;
                return identifier;
            }
            return TrySavePageStateToCache();
        }

        public bool TryGetPageStateFromCache(string identifier)
        {
            if (_cache.TryGetValue(identifier, out pageState))//get pageState from cache
                return true;
            throw new SessionExpiredException("session expired for" + identifier, HttpStatusCode.Forbidden);
        }


        public string TrySavePageStateToCache()
        {
            string requestIdentifier = Guid.NewGuid().ToString();
            string paginationState;

            if (!_cache.TryGetValue(requestIdentifier, out paginationState))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(Convert.ToDouble(Pagination.Timeout)));//set timeout

                _cache.Set(requestIdentifier, pageState, cacheEntryOptions);//insert in cache
                return requestIdentifier;
            }
            return identifier;
        }
    }
}

