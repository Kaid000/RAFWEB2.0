using RAFWEB2.Domain.Repositories;
using RAFWEB2.Domain.Repositories.Interfaces;

namespace RAFWEB2.API.Configuration.Extentions
{
   
    
        public static class RepositoriesExtention
        {
            public static void AddRepositoreis(this IServiceCollection services)
            {
            services.AddScoped<IAchievementRepository, AchievementRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
            services.AddScoped<IMainPageRepository, MainPageRepository>();
            services.AddScoped<IHolidayRepository, HolidayRepository>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();

        }
        }
    
}
