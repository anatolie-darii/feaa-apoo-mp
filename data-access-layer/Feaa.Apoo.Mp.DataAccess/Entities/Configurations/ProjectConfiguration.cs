using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feaa.Apoo.Mp.DataAccess.Entities.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Type);
            builder.Property(p => p.State);
            builder.Property(p => p.StartDate).IsRequired();

            builder.HasOne<Client>()
                   .WithMany()
                   .HasForeignKey(p => p.ClientId);

            builder.HasData();
        }
    }
}