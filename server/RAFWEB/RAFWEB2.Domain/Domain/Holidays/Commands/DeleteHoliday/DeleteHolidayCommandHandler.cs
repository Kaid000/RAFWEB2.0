using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Commands.DeleteHoliday
{
    public class DeleteHolidayCommandHandler : IRequestHandler<DeleteHolidayCommand, Holiday>
    {
        private readonly IHolidayRepository _repo;

        public DeleteHolidayCommandHandler(IHolidayRepository repo)
        {
            _repo = repo;
        }

        public async Task<Holiday> Handle(DeleteHolidayCommand request, CancellationToken cancellationToken)
        {
            return await _repo.RemoveAsync(request.Holiday);
        }
    }
}
