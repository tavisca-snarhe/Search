using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Net;
using static Tavisca.Applause.Constant;

namespace Tavisca.Applause
{
    public class BaseCustomPagination<T> : ICustomPagination<T>
    {
        private IMemoryCache _cache;

        public PaginationState<T> paginationParameters;
        public int pageSize;
        public string identifier;

        IValidationStrategy<T> validation;
        readonly int depth;
        int previousResultCount;
        int nullPageResultsCounter;

        public BaseCustomPagination(IMemoryCache cache,int depth)//set default vallues to variables
        {
            _cache = cache;
            this.depth = depth;
            previousResultCount = 0;
            paginationParameters = new PaginationState<T>();
        }

        public void SetValidationStrategy(IValidationStrategy<T> validation)// set validation strategy and set corresponding pagination parameters
        {
            this.validation = validation;
        }

        public bool ValidatePaginatedResult(int pageSize, int count, string pageState)
        {
            paginationParameters.PageState = pageState;
            if (count == previousResultCount)//check if no new results were added in results
            {
                nullPageResultsCounter++;
                if (depth == nullPageResultsCounter)//return if depth reached
                {
                    pageSize = 0;
                    identifier = null;
                    return true;
                }
            }
            if (count < pageSize)//check if count of results is less than pageSize
            {
                previousResultCount = count;
                this.pageSize = pageSize - count;//set new page size
                paginationParameters.AdditionalParameters = validation.UpdateAdditionalParameters();//set 
                return false;
            }
            identifier = TrySavePageStateToCache();
            return true;
        }

        public void SetPaginationState(string identifier, int pageSize)
        {
            this.pageSize = pageSize;
            this.identifier = identifier;
            if (identifier != null)
            {
                TryGetPageStateFromCache(identifier);
                paginationParameters.AdditionalParameters = validation.SetAdditionalParameters(paginationParameters.AdditionalParameters);
            }
            else
            {
                paginationParameters.AdditionalParameters = validation.SetAdditionalParameters();
            }
        }

        public bool TryGetPageStateFromCache(string identifier)
        {
            string pagingState;
            if (_cache.TryGetValue(identifier, out pagingState))//get pageState from cache
            {
                paginationParameters = JsonConvert.DeserializeObject<PaginationState<T>>(pagingState) ;
                return true;
            }
            throw new SessionExpiredException("session expired for " + identifier, HttpStatusCode.Forbidden);
        }

        public string TrySavePageStateToCache()
        {
            string requestIdentifier = Guid.NewGuid().ToString();
            PaginationState<T> paginationState;


            if (!_cache.TryGetValue(requestIdentifier, out paginationState))
            {
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(Convert.ToDouble(Pagination.Timeout)));//set timeout


                _cache.Set(requestIdentifier, JsonConvert.SerializeObject(paginationParameters), cacheEntryOptions);//insert in cache
                return requestIdentifier;
            }
            return identifier;
        }
    }
}