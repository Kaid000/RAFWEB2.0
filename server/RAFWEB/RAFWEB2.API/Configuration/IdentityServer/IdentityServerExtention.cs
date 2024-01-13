﻿using IdentityServer4.Models;
using Microsoft.Extensions.DependencyInjection;
using RAFWEB2.Data.Identity;
using IdentityServer4.AspNetIdentity;
using IdentityServer4.Services;

namespace RAFWEB2.API.Configuration.IdentityServer
{
    public static class IdentityServerExtentions
    {
        public static IServiceCollection AddIdentityServerInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            var identityServerSettingsSection = configuration.GetSection(nameof(IdentityServerSettings));
            var identityServerSettings = identityServerSettingsSection.Get<IdentityServerSettings>();

            services.Configure<IdentityServerSettings>(identityServerSettingsSection);

            services.AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
            })
                .AddInMemoryApiResources(new List<ApiResource>())
                .AddInMemoryIdentityResources(new List<IdentityResource>())
                .AddInMemoryApiScopes(new List<ApiScope>())
                .AddInMemoryClients(new List<Client>())
                .AddAspNetIdentity<User>()
                .AddDeveloperSigningCredential();



            return services;
        }
    }
}
