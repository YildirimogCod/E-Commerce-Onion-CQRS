
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.Property(p => p.Discount)
                .HasPrecision(18, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Title = "Kablosuz Klavye",
                    Description = "Günlük kullanım için kablosuz klavye.",
                    BrandId = 1,
                    Price = 1499.90m,
                    Discount = 10.00m,
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = false
                },
                new Product
                {
                    Id = 2,
                    Title = "Bluetooth Kulaklık",
                    Description = "Kablosuz bağlantılı kulak üstü kulaklık.",
                    BrandId = 3,
                    Price = 2499.90m,
                    Discount = 5.00m,
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = false
                }
            );
        }
    }
}
