using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserAuthApp.Data;

[assembly: HostingStartup(typeof(UserAuthApp.Areas.Identity.IdentityHostingStartup))]
namespace UserAuthApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserAuthAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserAuthAppContextConnection")));
               
            });
        }
    }
}