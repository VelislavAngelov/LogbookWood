namespace LogbookWood.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using LogbookWood.Data.Models;

    public class AssortmentSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Assortments.Any())
            {
                return;
            }

            await dbContext.Assortments.AddAsync(new Assortment { Name = "Едра", Category = (TreeCategory)1 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Средна", Category = (TreeCategory)2 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Дребна", Category = (TreeCategory)3 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Дърва", Category = (TreeCategory)4 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Вършина", Category = (TreeCategory)5 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Готови изделия", Category = (TreeCategory)6 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Изрезки и дърва преработени", Category = (TreeCategory)7 });
            await dbContext.Assortments.AddAsync(new Assortment { Name = "Фасонирана", Category = (TreeCategory)8 });

            await dbContext.SaveChangesAsync();
        }
    }
}
