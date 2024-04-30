using Microsoft.EntityFrameworkCore;            // DbSet |ishlashi uchun
using Users.Domain.Entities;                    // User |ishlashi uchun

namespace Users.Application.Abstractions
{
    public interface IUserDbContext
    {
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
