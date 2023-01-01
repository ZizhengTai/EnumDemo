using Microsoft.EntityFrameworkCore;
using EnumDemo.Entities;

namespace EnumDemo.Data;

public sealed class AppDbContext : DbContext
{
    public DbSet<MyEntity> MyEntities => Set<MyEntity>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
