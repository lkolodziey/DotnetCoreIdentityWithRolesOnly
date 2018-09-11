using System;
using DotnetCoreIdentityWithRolesOnly.Areas.Identity.Data;
using DotnetCoreIdentityWithRolesOnly.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DotnetCoreIdentityWithRolesOnly.Areas.Identity.IdentityHostingStartup))]
namespace DotnetCoreIdentityWithRolesOnly.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationUserDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddIdentity<PersonalizedUser, PersonalizedRole>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<ApplicationUserDbContext>();
            });
        }
    }
}