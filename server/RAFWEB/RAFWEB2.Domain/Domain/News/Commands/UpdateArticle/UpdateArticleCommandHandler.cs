using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.News.Command.UpdateArticle
{
    public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand, Article>
    {
        private readonly IArticleRepository _repo;

        public UpdateArticleCommandHandler(IArticleRepository repo) 
        {  
            _repo = repo; 
        }

        public async Task<Article> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            return await _repo.UpdateAsync(request.Article);
        }
    }
}
