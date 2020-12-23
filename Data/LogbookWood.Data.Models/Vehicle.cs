namespace LogbookWood.Data.Models
{
    using System;

    using LogbookWood.Data.Common.Models;

    public class Vehicle : BaseModel<string>
    {
        public Vehicle()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string RegistrationNumber { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
