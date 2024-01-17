using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.CreateHoliday
{
    public class AddHolidayCommandHandler : IRequestHandler<AddHolidayCommand, Holiday>
    {
        private readonly IHolidayRepository _repo;

        public AddHolidayCommandHandler(IHolidayRepository repo) 
        { 
            _repo = repo; 
        }

        public async Task<Holiday> Handle(AddHolidayCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.Holiday);
        }
    }
}
