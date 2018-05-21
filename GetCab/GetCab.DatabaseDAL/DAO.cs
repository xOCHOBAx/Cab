using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetCab.Common.Models;
using GetCab.DALContracts;
using GetCab.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GetCab.DatabaseDAL
{
    public class DAO : IDAO
    {


        public DAO()
        {

        }


        public bool Add()
        {
            throw new NotImplementedException();
        }


    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("GetCabDB", throwIfV1Schema: false)
        {

        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Order> Order { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("User");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Ride>().ToTable("Ride");
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
        }

    }
}
