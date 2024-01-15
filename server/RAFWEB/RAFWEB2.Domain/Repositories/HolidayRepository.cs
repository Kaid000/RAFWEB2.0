using RAFWEB2.Core.Context;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Repositories
{
    public class HolidayRepository : BaseRepository<Holiday>, IHolidayRepository
    {
        public HolidayRepository(ApplicationContext db) 
            : base(db)
        {
        }
    }
}
