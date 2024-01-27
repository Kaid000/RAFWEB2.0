using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.DeletePage
{
    public record DeletePageCommand(MainPageContent MainPageContent) : IRequest<MainPageContent>
    {
    }
}
