using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.CreateHoliday
{
    public class CreateHolidayCommandHandler : IRequestHandler<CreateHolidayCommand, Holiday>
    {
        private readonly IHolidayRepository _repo;

        public CreateHolidayCommandHandler(IHolidayRepository repo) 
        { 
            _repo = repo; 
        }

        public async Task<Holiday> Handle(CreateHolidayCommand request, CancellationToken cancellationToken)
        {
            return await _repo.CreateAsync(request.Holiday);
        }
    }
}
