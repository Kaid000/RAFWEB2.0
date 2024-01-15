using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.News.Command.AddArticle
{
    public record AddArticleCommand(Article Article) : IRequest<Article>
    {
    }
}
