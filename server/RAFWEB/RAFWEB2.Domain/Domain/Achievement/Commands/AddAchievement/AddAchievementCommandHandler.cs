using AutoMapper;
using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.AddAchievement
{
    public class AddAchievementCommandHandler : IRequestHandler<AddAchievementCommand, Achivement>
    {
        private readonly IAchievementRepository _repo;
        private readonly IMapper _mapper;
        public AddAchievementCommandHandler(IAchievementRepository repo, IMapper mapper) 
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<Achivement> Handle(AddAchievementCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Achivement>(request.Achivement);
            return await _repo.CreateAsync(value);
        }
    }
}
