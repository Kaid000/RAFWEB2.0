using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Holidays.Queries.GetAllHolidays
{
    public class GetAllHolidayQueryHandler : IRequestHandler<GetAllHolidayQuery, List<Holiday>>
    {
        private readonly IHolidayRepository _repo;

        public GetAllHolidayQueryHandler(IHolidayRepository repo) 
        {  
            _repo = repo; 
        }

        public async Task<List<Holiday>> Handle(GetAllHolidayQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAll();
        }
    }
}
