using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Achievement.Queries.GetAchivementById
{
    public class GetAchievementByIdQueryHandler : IRequestHandler<GetAchievementByIdQuery, Achivement>
    {
        private readonly IAchievementRepository _repo;

        public GetAchievementByIdQueryHandler(IAchievementRepository repo)
        {
            _repo = repo;
        }
        public async Task<Achivement> Handle(GetAchievementByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByAsync(x => x.Id == request.id);
        }
    }
}
