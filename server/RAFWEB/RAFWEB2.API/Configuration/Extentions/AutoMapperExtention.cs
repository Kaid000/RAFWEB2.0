using AutoMapper;
using RAFWEB2.Data.Models;
using RAFWEB2.Domain.Mapping.Achievements;
using RAFWEB2.Domain.Mapping.Contacts;
using RAFWEB2.Domain.Mapping.Holidays;
using RAFWEB2.Domain.Mapping.News;
using RAFWEB2.Domain.Mapping.Organizations;
using RAFWEB2.Domain.Mapping.Pages;

namespace RAFWEB2.API.Configuration.Extentions
{
    public static class AutoMapperExtention
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new OrganizationProfile());
                mc.AddProfile(new ArticleProfile());
                mc.AddProfile(new MainPageProfile());
                mc.AddProfile(new ContactInfoProfile());
                mc.AddProfile(new HolidayProfile());
                mc.AddProfile(new AchievementProfile());

            });
            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
