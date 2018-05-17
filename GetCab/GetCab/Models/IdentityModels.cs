using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using GetCab.WebUI;
using GetCab.Models;

namespace GetCab.WebUI.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser<string,IdentityUserLogin<string>,ApplicationUserRole,IdentityUserClaim<string>>
    {
        public string Login { get; set; }
        public string Phone { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }

    public class ApplicationUserContext : DbContext
    {
        public ApplicationUserContext() :
                base("GetCabDB")
        {
        }
        public DbSet<ApplicationUser> Users { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("GetCabDB")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Ride> Rides{ get; set; }
        public DbSet<Car> Cars{ get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ApplicationUser>().Map(c =>
        //    {
        //        c.ToTable("User");
        //    });
            
        //    modelBuilder.Entity<IdentityRole>().HasKey(r => new { r.User_Id, r.Role_Id}).ToTable("UserRoles");
        //}
    }

    public class ApplicationRole : IdentityRole<string, ApplicationUserRole>
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
    }

    public class ApplicationUserRole : IdentityUserRole<string> { }
    
   
}