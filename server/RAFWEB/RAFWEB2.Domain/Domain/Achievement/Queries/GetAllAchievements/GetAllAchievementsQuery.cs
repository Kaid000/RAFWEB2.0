using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Achievement.Queries.GetAllAchievements
{
    public record GetAllAchievementsQuery() : IRequest<List<Achivement>>
    {
    }
}
