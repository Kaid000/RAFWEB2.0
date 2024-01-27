using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Holidays.Queries.GetAllHolidays
{
    public record GetAllHolidayQuery : IRequest<List<Holiday>>
    {
    }
}
