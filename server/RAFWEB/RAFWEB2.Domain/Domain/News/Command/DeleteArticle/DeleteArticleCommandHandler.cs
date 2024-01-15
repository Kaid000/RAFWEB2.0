using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.News.Command.DeleteArticle
{
    public class DeleteArticleCommandHandler : IRequestHandler<DeleteArticleCommand, Article>
    {
        private readonly IArticleRepository _repo;

        public DeleteArticleCommandHandler(IArticleRepository repo)
        {
            _repo = repo;
        }

        public async Task<Article> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
        {
            return await _repo.RemoveAsync(request.Article);
        }
    }
}
