using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.News.Command.DeleteArticle
{
    public record DeleteArticleCommand(Article Article) : IRequest<Article>
    {
    }
}
