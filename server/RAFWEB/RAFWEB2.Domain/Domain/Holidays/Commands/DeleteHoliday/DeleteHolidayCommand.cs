using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.DeleteHoliday
{
    public record DeleteHolidayCommand(Holiday Holiday) : IRequest<Holiday>
    {
    }
}
