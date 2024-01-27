using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.MainPage.Queries.GetAllPages
{
    public record GetAllPagesQuery : IRequest<List<MainPageContent>>
    {
    }
}
