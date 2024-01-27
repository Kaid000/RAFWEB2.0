using RAFWEB2.API.Configuration.Extentions;
using RAFWEB2.Core.Context;
using RAFWEB2.Domain.Domain.Achievement.Commands.AddAchievement;
using RAFWEB2.Domain.Domain.Achievement.Commands.DeleteAchivement;
using RAFWEB2.Domain.Domain.Achievement.Commands.UpdateAchievement;
using RAFWEB2.Domain.Domain.Achievement.Queries.GetAchivementById;
using RAFWEB2.Domain.Domain.Achievement.Queries.GetAllAchievements;
using RAFWEB2.Domain.Domain.Contacts.Commands.CreateContact;
using RAFWEB2.Domain.Domain.Contacts.Commands.DeleteContact;
using RAFWEB2.Domain.Domain.Contacts.Commands.UpdateContact;
using RAFWEB2.Domain.Domain.Contacts.Queries.GetAllContacts;
using RAFWEB2.Domain.Domain.Contacts.Queries.GetContactById;
using RAFWEB2.Domain.Domain.Holidays.Commands.CreateHoliday;
using RAFWEB2.Domain.Domain.Holidays.Commands.DeleteHoliday;
using RAFWEB2.Domain.Domain.Holidays.Commands.UpdateHoliday;
using RAFWEB2.Domain.Domain.Holidays.Queries.GetAllHolidays;
using RAFWEB2.Domain.Domain.Holidays.Queries.GetHolidayById;
using RAFWEB2.Domain.Domain.MainPage.Commands.AddPage;
using RAFWEB2.Domain.Domain.MainPage.Commands.DeletePage;
using RAFWEB2.Domain.Domain.MainPage.Commands.UpdatePage;
using RAFWEB2.Domain.Domain.MainPage.Queries.GetAllPages;
using RAFWEB2.Domain.Domain.MainPage.Queries.GetPageById;
using RAFWEB2.Domain.Domain.News.Command.AddArticle;
using RAFWEB2.Domain.Domain.News.Command.DeleteArticle;
using RAFWEB2.Domain.Domain.News.Command.UpdateArticle;
using RAFWEB2.Domain.Domain.News.Queries.GetAllArticles;
using RAFWEB2.Domain.Domain.News.Queries.GetArticleById;
using RAFWEB2.Domain.Domain.Organization.Commands.AddOrganization;
using RAFWEB2.Domain.Domain.Organization.Commands.DeleteOrganization;
using RAFWEB2.Domain.Domain.Organization.Commands.UpdateOrganization;
using RAFWEB2.Domain.Domain.Organization.Queries.GetAllOrganization;
using RAFWEB2.Domain.Domain.Organization.Queries.GetOrganizationById;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceInfrastructure(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationContext>();
builder.Services.AddRepositoreis();
builder.Services.AddMediatR(x =>
{
    x.RegisterServicesFromAssemblies(typeof(AddArticleCommand).Assembly, typeof(AddArticleCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(DeleteArticleCommand).Assembly, typeof(DeleteArticleCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(UpdateArticleCommand).Assembly, typeof(UpdateArticleCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAllArticleQuery).Assembly, typeof(GetAllArticleQueryHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetArticleByIdQuery).Assembly, typeof(GetArticleByIdQueryHandler).Assembly);

    x.RegisterServicesFromAssemblies(typeof(AddOrganizationCommand).Assembly, typeof(AddOrganizationCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(DeleteOrganizationCommand).Assembly, typeof(DeleteOrganizationCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(UpdateOrganizationCommand).Assembly, typeof(UpdateOrganizationCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAllOrganizationQuery).Assembly, typeof(GetAllOrganizationQueryHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetOrganizationByIdQuery).Assembly, typeof(GetOrganiztaionByIdQueryHandler).Assembly);

    x.RegisterServicesFromAssemblies(typeof(AddPageCommand).Assembly, typeof(AddPageCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(DeletePageCommand).Assembly, typeof(DeletePageCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(UpdatePageCommand).Assembly, typeof(UpdatePageCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAllPagesQuery).Assembly, typeof(GetAllPagesQueryHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetPageByIdQuery).Assembly, typeof(GetPageByIdQueryHandler).Assembly);

    x.RegisterServicesFromAssemblies(typeof(AddAchievementCommand).Assembly, typeof(AddAchievementCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(DeleteAchievementCommand).Assembly, typeof(DeleteAchivementCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(UpdateAchievementCommand).Assembly, typeof(UpdateAchivementCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAllAchievementsQuery).Assembly, typeof(GetAllAchievementsQueryHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAchievementByIdQuery).Assembly, typeof(GetAchievementByIdQueryHandler).Assembly);

    x.RegisterServicesFromAssemblies(typeof(AddContactCommand).Assembly, typeof(AddContactCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(DeleteContactCommand).Assembly, typeof(DeleteContactCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(UpdateContactCommand).Assembly, typeof(UpdateContactCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAllContactsQuery).Assembly, typeof(GetAllContactsQueryHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetContactByIdQuery).Assembly, typeof(GetContactByIdQueryHandler).Assembly);

    x.RegisterServicesFromAssemblies(typeof(AddHolidayCommand).Assembly, typeof(AddHolidayCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(DeleteHolidayCommand).Assembly, typeof(DeleteHolidayCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(UpdateHolidayCommand).Assembly, typeof(UpdateHolidayCommandHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetAllHolidayQuery).Assembly, typeof(GetAllHolidayQueryHandler).Assembly);
    x.RegisterServicesFromAssemblies(typeof(GetHolidayByIdQuery).Assembly, typeof(GetHolidayByIdQueryHandler).Assembly);
});
builder.Services.AddPersistenceInfrastructure(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
