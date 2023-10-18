using lab3.Models;
using Microsoft.Extensions.Caching.Memory;

namespace lab3.Data
{
    public class InsuranceCompanyСache
    {
        private IMemoryCache _cache;
        private InsuranceCompanyContext _db;
        private const int CACHE_SAVE_TIME = 2 * 16 + 240;


        public InsuranceCompanyСache(InsuranceCompanyContext db, IMemoryCache memoryCache)
        {
            _db = db;
            _cache = memoryCache;
        }

        public IEnumerable<IEntity> GetEnites(string entityName, int rowCount = 20)
        {
            _cache.TryGetValue(entityName, out IEnumerable<IEntity>? entities);

            if (entities is null)
            {
                entities = InsuranceCompanyFactory.GetEnites(entityName, _db).Take(rowCount);
                _cache.Set($"{entityName}{rowCount}", entities, new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(CACHE_SAVE_TIME)));
            }
            return entities;
        }
    }
}