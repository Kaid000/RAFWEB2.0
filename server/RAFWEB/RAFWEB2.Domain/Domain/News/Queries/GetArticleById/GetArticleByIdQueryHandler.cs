using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.News.Queries.GetArticleById
{
    public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery, Article>
    {
        private readonly IArticleRepository _repo;

        public GetArticleByIdQueryHandler(IArticleRepository repo)
        {
            _repo = repo;
        }

        public async Task<Article> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByAsync(x => x.Id == request.id);
        }
    }
}
