using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Holidays.Queries.GetHolidayById
{
    public record GetHolidayByIdQuery(Guid id) : IRequest<Holiday>
    {
    }
}
