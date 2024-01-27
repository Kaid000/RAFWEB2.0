using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Achievement.Queries.GetAllAchievements
{
    public class GetAllAchievementsQueryHandler : IRequestHandler<GetAllAchievementsQuery, List<Achivement>>
    {
        private readonly IAchievementRepository _repo;

        public GetAllAchievementsQueryHandler(IAchievementRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<Achivement>> Handle(GetAllAchievementsQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAll();
        }
    }
}
