using LogbookWood.Data;
using LogbookWood.Data.Common.Repositories;
using LogbookWood.Data.Models;
using LogbookWood.Web.ViewModels.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogbookWood.Services.Data.Models
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository<Vehicle> vechicleRepository;
        private readonly ApplicationDbContext dbContext;

        public VehicleService(IRepository<Vehicle> vechicleRepository, ApplicationDbContext dbContext)
        {
            this.vechicleRepository = vechicleRepository;
            this.dbContext = dbContext;
        }

        public void Create(CreateVehicleViewModel input, string userId)
        {
            Vehicle vehicle = new Vehicle
            {
                RegistrationNumber = input.RegistrationNumber,
                Brand = input.Brand,
                Model = input.Model,
                UserId = userId,
            };

            this.dbContext.Vehicles.Add(vehicle);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<ListVehicleInViewModel> GetAll(string userId)
        {
            return this.vechicleRepository.All()
                .Where(x => x.UserId == userId)
                .Select(x => new ListVehicleInViewModel
                {
                    RegistrationNumber = x.RegistrationNumber,
                    Brand = x.Brand,
                    Model = x.Model,
                })
                .ToList();
        }
    }
}
