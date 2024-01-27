using AutoMapper;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.Domain.Mapping.Achievements
{
    public class AchievementProfile : Profile
    {
        public AchievementProfile()
        {
            CreateMap<AchivementDTO, Achivement>();

            CreateMap<Achivement, AchivementDTO>();
        }
    }
}
