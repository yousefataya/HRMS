using DotNetCore.AspNetCore;
using DotNetCore.IoC;
using DotNetCoreArchitecture.Application;
using DotNetCoreArchitecture.Database;
using HRMS.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetCoreArchitecture.Web
{
    public static class Extensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddClassesMatchingInterfaces(typeof(IUserApplicationService).Assembly);
            services.AddClassesMatchingInterfaces(typeof(IItemApplicationService).Assembly);
            services.AddClassesMatchingInterfaces(typeof(ICatogryApplicationService).Assembly);
        }


        public static void AddContext(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();

            var connectionString = configuration.GetConnectionString(nameof(Context));

            services.AddDbContextMigrate<Context>(options => options.UseSqlServer("Server=DESKTOP-I3Q3RDU;Database=HrModule;User Id=sa; Password=opc@2018;"));
        }

        public static void AddDatabaseServices(this IServiceCollection services)
        {
            services.AddClassesMatchingInterfaces(typeof(IUnitOfWork).Assembly);
        }

        public static void AddInfraServices(this IServiceCollection services)
        {
            services.AddClassesMatchingInterfaces(typeof(ISignInService).Assembly);
        }

        public static void AddSecurity(this IServiceCollection services)
        {
            services.AddHash(10000, 128);
            services.AddJsonWebToken(Guid.NewGuid().ToString(), TimeSpan.FromHours(12));
            services.AddAuthenticationJwtBearer();
        }

        public static void AddSpa(this IServiceCollection services)
        {
            services.AddSpaStaticFiles("Frontend/dist");
        }

        public static void UseSpa(this IApplicationBuilder application)
        {
            application.UseSpaAngularServer("Frontend", "development");
        }
    }
}
