using MediatR;                                              // AddMediatR |ishlashi uchun
using Microsoft.Extensions.DependencyInjection;             // IServiceCollection |ishlashi uchun
using System.Reflection;                                    // Assembly |ishlashi uchun 


namespace Users.Application
{
    public static class UsersApplicationDependencyInjection
    {
        public static IServiceCollection AddUsersApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            //       ^^^^^^^^^^ -> AddMediatR to'g'ri ishlashi uchun [MediatR.Extensions.Microsoft.DependencyInjection] ko'chirilishi va versiyasi MediatR bilan bir xil bolmog'i lozim
            return services;
        }
    }
}
