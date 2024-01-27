using AutoMapper;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.Domain.Mapping.Organizations
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<StudentOrganizationDTO, StudentOrganization>();

            CreateMap<StudentOrganization, StudentOrganizationDTO>();
        }
    }
}
