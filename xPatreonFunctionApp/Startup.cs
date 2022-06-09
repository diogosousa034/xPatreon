using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Implementation;
using Services.Interfaces;

[assembly: FunctionsStartup(typeof(xPatreonFunctionApp.Startup))]

namespace xPatreonFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //builder.Services.AddHttpClient();

            //builder.Services.AddSingleton<xPatreonDbContext>((s) =>
            //{
            //    return new MyService();
            //});

            builder.Services.AddDbContext<xPatreonDbContext>(options =>
                options.UseSqlServer(Environment.GetEnvironmentVariable("DefaultConnection"))
                );

            builder.Services.AddSingleton<IUserService, UserService>();
        }
    }
}
