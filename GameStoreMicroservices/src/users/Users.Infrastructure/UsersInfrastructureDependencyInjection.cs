using Users.Application.Abstractions;                       // IApplicationDbContext |ishlashi uchun    
using Users.Infrastructure.Persistance;                     // ApplicationDbContext |ishlashi uchun
using Microsoft.EntityFrameworkCore;                        // UseNpgsql |ishlashi uchun
using Microsoft.Extensions.Configuration;                   // IConfiguration |ishlashi uchun   
using Microsoft.Extensions.DependencyInjection;             // IServiceCollection |ishlashi uchun

namespace Users.Infrastructure
{
    public static class UsersInfrastructureDependencyInjection
    {
        public static IServiceCollection AddUsersInfrastructure(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<IUserDbContext, UserDbContext>(options =>
            {
                options.UseNpgsql(config["ConnectionStrings:DefaultConnection"]);
            });

            return services;
        }
    }
}
