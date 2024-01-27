using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.Domain.Repositories.Interfaces
{
    public interface IAchievementRepository : IBaseRepository<Achivement>
    {
        Task<Achivement> CreateAsync(AchivementDTO achivement);
    }
}
