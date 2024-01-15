using MediatR;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.AddAchievement
{
    public record AddAchievementCommand(Achivement Achivement) : IRequest<Achivement>
    {
    }
}
