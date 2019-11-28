using Microsoft.Extensions.Caching.Memory;

namespace Tavisca.Applause
{
    public class PaginationFactory : IPaginationFactory
    {
        IMemoryCache _cache;
        public PaginationFactory(IMemoryCache cache)
        {
            _cache = cache;
        }

        public BaseCustomPagination<T> GetCustomPagination<T>(int depth)
        {
            return new BaseCustomPagination<T>(_cache,depth);
        }

        public SimplePagination GetSimplePagination()
        {
            return new SimplePagination(_cache);
        }
    }
}
