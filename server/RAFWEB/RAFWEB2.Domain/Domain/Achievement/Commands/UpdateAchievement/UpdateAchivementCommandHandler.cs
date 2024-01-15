using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.UpdateAchievement
{
    public class UpdateAchivementCommandHandler : IRequestHandler<UpdateAchievementCommand, Achivement>
    {
        private readonly IAchievementRepository _repo;
        public UpdateAchivementCommandHandler(IAchievementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Achivement> Handle(UpdateAchievementCommand request, CancellationToken cancellationToken)
        {
            return await _repo.UpdateAsync(request.Achivement);
        }
    }
}
