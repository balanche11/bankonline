using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       public DbSet<Brand>Brands { get; set; }
       
       public DbSet<TypeOfCard> TypeOfCards { get; set; }

       public DbSet<Card> Cards { get; set; }
       
       public DbSet<Customer> Customers { get; set; }

       public DbSet<Request> Requests { get; set; }

       public DbSet<PhysicalCard> PhysicalCards { get; set; }

       public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
       {

       }

       public static ApplicationDbContext Create()
       {
            return new ApplicationDbContext();
       }

    }
}