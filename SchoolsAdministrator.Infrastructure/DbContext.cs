using Microsoft.EntityFrameworkCore;
using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Infrastructure.Data.Configurations;

namespace SchoolsAdministrator.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) 
        : base(options)
    {

    }
    public AppDbContext()
    {
        
    }
    public DbSet<School> Schools { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new SchoolConfiguration());
        builder.ApplyConfiguration(new ClassroomConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) 
        {
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolsAdministrator;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
