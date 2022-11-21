using WalksAPI.Models.domain;

namespace WalksAPI.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
