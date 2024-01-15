using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.News.Queries.GetAllArticles
{
    public record GetAllArticleQuery() : IRequest<List<Article>>
    {
    }
}
