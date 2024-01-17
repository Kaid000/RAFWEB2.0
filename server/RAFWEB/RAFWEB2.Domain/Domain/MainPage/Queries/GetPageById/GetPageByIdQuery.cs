using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.MainPage.Queries.GetPageById
{
    public record GetPageByIdQuery(Guid id) : IRequest<MainPageContent>
    {
    }
}
