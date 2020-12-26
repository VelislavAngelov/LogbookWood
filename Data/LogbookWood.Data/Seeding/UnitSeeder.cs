namespace LogbookWood.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using LogbookWood.Data.Models;

    public class UnitSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Units.Any())
            {
                return;
            }

            await dbContext.Units.AddAsync(new Unit { Name = "м3", Coefficient = 1 });
            await dbContext.Units.AddAsync(new Unit { Name = "простр.м3", Coefficient = 0.00 });

            await dbContext.SaveChangesAsync();
        }
    }
}
