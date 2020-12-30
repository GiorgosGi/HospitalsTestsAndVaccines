﻿using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HospitalsTestsAndVaccines.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Όνομα")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Επίθετο")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Τηλέφωνο")]
        public string Phone { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<HospitalsTestsAndVaccines.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<HospitalsTestsAndVaccines.Models.Hospital> Hospitals { get; set; }

        public System.Data.Entity.DbSet<HospitalsTestsAndVaccines.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<HospitalsTestsAndVaccines.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<HospitalsTestsAndVaccines.Models.Payment> Payments { get; set; }

        public System.Data.Entity.DbSet<HospitalsTestsAndVaccines.Models.ContactDetails> ContactDetails { get; set; }
    }
}