using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.AddPage
{
    public class AddPageCommandHandler : IRequestHandler<AddPageCommand,MainPageContent>
    {
        private readonly IMainPageRepository _repo;

        public AddPageCommandHandler(IMainPageRepository repo)
        {
            _repo = repo;
        }

        public async Task<MainPageContent> Handle(AddPageCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.MainPageContent);
        }
    }
}
