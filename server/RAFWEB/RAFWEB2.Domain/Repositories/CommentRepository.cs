using RAFWEB2.Core.Context;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationContext db) 
            : base(db)
        {
        }
    }
}
