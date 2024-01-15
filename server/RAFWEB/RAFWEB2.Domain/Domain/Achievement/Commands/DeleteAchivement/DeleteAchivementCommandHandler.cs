using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.DeleteAchivement
{
    public class DeleteArticleCommandHandler : IRequestHandler<DeleteAchievementCommand, Achivement>
    {
        private readonly IAchievementRepository _repo;
        public DeleteArticleCommandHandler(IAchievementRepository repo)
        {
            _repo = repo;
        }
        public async Task<Achivement> Handle(DeleteAchievementCommand request, CancellationToken cancellationToken)
        {
            return await _repo.RemoveAsync(request.Achivement);
        }
    }
}
