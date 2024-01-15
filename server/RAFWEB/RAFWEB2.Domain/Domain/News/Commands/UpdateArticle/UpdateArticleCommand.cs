using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.News.Command.UpdateArticle
{
    public record UpdateArticleCommand(Article Article) : IRequest<Article>
    {
    }
}
