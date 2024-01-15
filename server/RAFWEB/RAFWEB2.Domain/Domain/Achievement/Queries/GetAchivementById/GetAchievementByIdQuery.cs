using MediatR;
using RAFWEB2.Data.Models;

namespace RAFWEB2.Domain.Domain.Achievement.Queries.GetAchivementById
{
    public record GetAchievementByIdQuery(Guid id) : IRequest<Achivement>
    {
    }
}
