using Feaa.Apoo.Mp.DataAccess.Entities;
using Feaa.Apoo.Mp.DataAccess.Entities.Configurations;

using Microsoft.EntityFrameworkCore;

namespace Feaa.Apoo.Mp.DataAccess
{
    public class MpDbContext : DbContext
    {
        public MpDbContext(DbContextOptions<MpDbContext> options)
            : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }
    }
}