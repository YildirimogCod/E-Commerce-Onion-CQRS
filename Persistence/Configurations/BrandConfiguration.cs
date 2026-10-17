
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(b => b.Name)
                .HasMaxLength(256);

            builder.HasData(
                new Brand
                {
                    Id = 1,
                    Name = "Teknoloji",
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 2,
                    Name = "Moda",
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = false
                },
                new Brand
                {
                    Id = 3,
                    Name = "Ev ve Yaşam",
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = true
                }
            );
        }
    }
}
