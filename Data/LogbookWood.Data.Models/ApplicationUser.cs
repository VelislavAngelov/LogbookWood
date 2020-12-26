// ReSharper disable VirtualMemberCallInConstructor
namespace LogbookWood.Data.Models
{
    using System;
    using System.Collections.Generic;

    using LogbookWood.Data.Common.Models;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Counterparties = new HashSet<Counterparties>();
            this.Employees = new HashSet<Employee>();
            this.Vehicles = new HashSet<Vehicle>();
        }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public string BULSTST { get; set; }

        public string Phone { get; set; }

        //// Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public string TicketId { get; set; }

        public virtual Ticket Tickets { get; set; }

        public ICollection<Counterparties> Counterparties { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
