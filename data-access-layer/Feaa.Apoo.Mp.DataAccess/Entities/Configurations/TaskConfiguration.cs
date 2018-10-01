using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feaa.Apoo.Mp.DataAccess.Entities.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.State).IsRequired();

            builder.HasOne(task => task.Project)
                   .WithMany(project => project.Tasks)
                   .HasForeignKey(p => p.ProjectId);

            builder.HasData();
        }
    }
}