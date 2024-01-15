using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.UpdateHoliday
{
    public class UpdateHolidayCommandHandler : IRequestHandler<UpdateHolidayCommand, Holiday>
    {
        private readonly IHolidayRepository _repo;

        public UpdateHolidayCommandHandler(IHolidayRepository repo)
        {
            _repo = repo;
        }
        public async Task<Holiday> Handle(UpdateHolidayCommand request, CancellationToken cancellationToken)
        {
            return await _repo.UpdateAsync(request.Holiday);
        }
    }
}
