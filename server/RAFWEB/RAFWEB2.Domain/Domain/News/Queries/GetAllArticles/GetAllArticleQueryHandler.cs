using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.News.Queries.GetAllArticles
{
    public class GetAllArticleQueryHandler : IRequestHandler<GetAllArticleQuery, List<Article>>
    {
        private readonly IArticleRepository _repo;

        public GetAllArticleQueryHandler(IArticleRepository repo)
        {
            _repo = repo;
        }

        public Task<List<Article>> Handle(GetAllArticleQuery request, CancellationToken cancellationToken)
        {
            return _repo.GetAll();
        }
    }
}
