using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Queries.GetHolidayById
{
    public class GetHolidayByIdQueryHandler : IRequestHandler<GetHolidayByIdQuery, Holiday>
    {
        private readonly IHolidayRepository _repo;

        public GetHolidayByIdQueryHandler(IHolidayRepository repo)
        {
            _repo = repo;
        }

        public async Task<Holiday> Handle(GetHolidayByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetByAsync(x => x.Id == request.id);
        }
    }
}
