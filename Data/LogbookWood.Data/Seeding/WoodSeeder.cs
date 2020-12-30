namespace LogbookWood.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using LogbookWood.Data.Models;

    public class WoodSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Woods.Any())
            {
                return;
            }

            await dbContext.Woods.AddAsync(new Wood { Name = "Широколистни", Type = 0, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Бук", Type = 0, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Дъб", Type = 0, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Цер", Type = 0, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Акация", Type = 0, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Габър", Type = 0, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Иглолистни", Type = (TreeSpecies)1, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Смърч", Type = (TreeSpecies)1, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Бял бор", Type = (TreeSpecies)1, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Ела", Type = (TreeSpecies)1, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Черен бор", Type = (TreeSpecies)1, });
            await dbContext.Woods.AddAsync(new Wood { Name = "Кедър", Type = (TreeSpecies)1, });

            await dbContext.SaveChangesAsync();
        }
    }
}
