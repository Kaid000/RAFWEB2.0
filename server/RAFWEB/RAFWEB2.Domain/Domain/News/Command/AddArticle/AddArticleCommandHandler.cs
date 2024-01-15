using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAFWEB2.Domain.Domain.News.Command.AddArticle
{
    public class AddArticleCommandHandler : IRequestHandler<AddArticleCommand, Article>
    {
        private readonly IArticleRepository _repo;

        public AddArticleCommandHandler(IArticleRepository repo)
        {
            _repo = repo;
        }

        public async Task<Article> Handle(AddArticleCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.Article);
        }
    }
}
