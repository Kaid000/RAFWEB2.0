using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.AddAchievement
{
    public class AddAchievementCommandHandler : IRequestHandler<AddAchievementCommand, Achivement>
    {
        private readonly IAchievementRepository _repo;
        public AddAchievementCommandHandler(IAchievementRepository repo) 
        {
            _repo = repo;
        }
        public async Task<Achivement> Handle(AddAchievementCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.Achivement);
        }
    }
}
