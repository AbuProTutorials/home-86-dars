using Users.Application;            // AddApplication |ishlashi uchun
using Users.Infrastructure;         // AddInfrastructure |ishlashi uchun

namespace Users.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddUsersApplication();                         // Dependency Injection qo'shish
            builder.Services.AddUsersInfrastructure(builder.Configuration); // Dependency Injection qo'shish

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
