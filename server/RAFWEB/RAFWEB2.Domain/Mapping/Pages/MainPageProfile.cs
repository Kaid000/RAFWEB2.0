using AutoMapper;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.Domain.Mapping.Pages
{
    public class MainPageProfile : Profile
    {
        public MainPageProfile()
        {
            CreateMap<MainPageDTO, MainPageContent>();

            CreateMap<MainPageContent, MainPageDTO>();
        }
    }
}
