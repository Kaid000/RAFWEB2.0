using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.UpdateAchievement
{
    public record UpdateAchievementCommand(Achivement Achivement) : IRequest<Achivement>
    {
    }
}
