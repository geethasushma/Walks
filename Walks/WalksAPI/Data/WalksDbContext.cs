using Microsoft.EntityFrameworkCore;
using WalksAPI.Models.domain;
using WalksAPI.modelss.domain;

namespace WalksAPI.Data
{
    public class WalksDbContext: DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
