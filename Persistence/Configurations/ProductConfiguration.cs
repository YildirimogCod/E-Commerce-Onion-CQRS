using Bogus;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           Faker faker = new Faker("tr");
           Product product1 = new Product()
           {
               Id = 1,
               Title = faker.Commerce.ProductName(),
               Description = faker.Commerce.ProductDescription(),
               BrandId = 1,
               Discount = faker.Random.Decimal(0,10),
               Price = faker.Finance.Amount(10,100),
               CreatedDate = DateTime.Now,
               IsDeleted = false,
           };
            Product product2 = new Product()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 3,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 100),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            builder.HasData(product1,product2);
        }
    }
}
