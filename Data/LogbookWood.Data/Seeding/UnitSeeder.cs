using LogbookWood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogbookWood.Data.Seeding
{
    public class UnitSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Units.Any())
            {
                return;
            }

            await dbContext.Units.AddAsync(new Unit { Name = "м3", Coefficient = 1 });
            await dbContext.Units.AddAsync(new Unit { Name = "прост.м3", Coefficient = 0 });

            await dbContext.SaveChangesAsync();
        }
    }
}
