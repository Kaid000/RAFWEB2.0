using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.News.Queries.GetArticleById
{
    public record GetArticleByIdQuery(Guid id) : IRequest<Article>
    {
    }
}
