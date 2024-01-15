using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.CreateHoliday
{
    public record CreateHolidayCommand(Holiday Holiday) : IRequest<Holiday>
    {
    }
}
