using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.MainPage.Commands.UpdatePage
{
    public record UpdatePageCommand(MainPageContent MainPageContent) : IRequest<MainPageContent>
    {
    }
}
