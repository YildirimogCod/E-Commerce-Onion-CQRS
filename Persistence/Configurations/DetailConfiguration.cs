
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.HasData(
                new Detail
                {
                    Id = 1,
                    Title = "Teknik Özellikler",
                    Description = "Ürünün teknik özellikleri ve kullanım bilgileri.",
                    CategoryId = 1,
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = false
                },
                new Detail
                {
                    Id = 2,
                    Title = "Bilgisayar Özellikleri",
                    Description = "Bilgisayar bileşenleri ve donanım bilgileri.",
                    CategoryId = 3,
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = false
                },
                new Detail
                {
                    Id = 3,
                    Title = "Kadın Giyim Detayları",
                    Description = "Kadın giyim ürünleri ve kumaş özellikleri.",
                    CategoryId = 4,
                    CreatedDate = new DateTime(2026, 1, 1),
                    IsDeleted = true
                }
            );
        }
    }
}
