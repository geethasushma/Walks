using Microsoft.EntityFrameworkCore;
using WalksAPI.Data;
using WalksAPI.Models.domain;

namespace WalksAPI.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalksDbContext walksDbContext;

        public RegionRepository(WalksDbContext walksDbContext)
        {
            this.walksDbContext = walksDbContext;
        } 


        public async Task<IEnumerable<Region>> GetAllAsync() 
        {
            return await walksDbContext.Regions.ToListAsync();
            
        }
    }
}
