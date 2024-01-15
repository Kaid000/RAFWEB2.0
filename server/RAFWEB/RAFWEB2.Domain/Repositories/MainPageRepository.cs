using RAFWEB2.Core.Context;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Repositories
{
    public class MainPageRepository : BaseRepository<MainPageContent>, IMainPageRepository
    {
        public MainPageRepository(ApplicationContext db) 
            : base(db)
        {
        }
    }
}
