using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Achievement.Commands.DeleteAchivement
{
    public record DeleteAchievementCommand(Achivement Achivement) : IRequest<Achivement>
    {
    }
}
