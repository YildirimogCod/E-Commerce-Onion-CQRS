
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Elektrik",
                    Priority = 1,
                    ParentId = 0,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2026, 1, 1)
                },
                new Category
                {
                    Id = 2,
                    Name = "Moda",
                    Priority = 2,
                    ParentId = 0,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2026, 1, 1)
                },
                new Category
                {
                    Id = 3,
                    Name = "Bilgisayar",
                    Priority = 1,
                    ParentId = 1,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2026, 1, 1)
                },
                new Category
                {
                    Id = 4,
                    Name = "Kadın",
                    Priority = 1,
                    ParentId = 2,
                    IsDeleted = false,
                    CreatedDate = new DateTime(2026, 1, 1)
                }
            );
        }
    }
}
