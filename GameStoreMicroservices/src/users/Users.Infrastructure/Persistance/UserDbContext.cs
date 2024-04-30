using Microsoft.EntityFrameworkCore;            // DbContext, DbContextOptions |ishlashi uchun       
using Users.Application.Abstractions;           // IUserDbContext |ishlashi uchun
using Users.Domain.Entities;                    // User |ishlashi uchun        

namespace Users.Infrastructure.Persistance
{
    public class UserDbContext : DbContext, IUserDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options):base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken=default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
