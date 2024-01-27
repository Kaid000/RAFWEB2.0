﻿using AutoMapper;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.DTO;

namespace RAFWEB2.Domain.Mapping.Contacts
{
    public class ContactInfoProfile : Profile
    {
        public ContactInfoProfile()
        {
            CreateMap<ContactInfoDTO, ContactInfo>();

            CreateMap<ContactInfo, ContactInfoDTO>();
        }
    }
}
