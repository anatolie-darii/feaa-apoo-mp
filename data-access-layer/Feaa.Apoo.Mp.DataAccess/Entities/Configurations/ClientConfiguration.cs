using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feaa.Apoo.Mp.DataAccess.Entities.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Address).IsRequired();

            builder.HasMany<Project>(client => client.Projects)
                   .WithOne(project => project.Client)
                   .HasForeignKey(p => p.ClientId);

            builder.HasData();
        }
    }
}