using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.UpdateHoliday
{
    public record UpdateHolidayCommand(Holiday Holiday) : IRequest<Holiday>
    {
        
    }
}
