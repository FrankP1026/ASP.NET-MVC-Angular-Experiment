namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using WebApplication1.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(
                p => p.Name,
                new Product { Name = "Apple", Price = 3 },
                new Product { Name = "Banana", Price = 4 },
                new Product { Name = "Orange", Price = 5 }
            );

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var role = new IdentityRole("Admin");
                context.Roles.Add(role);
            }

            if (!context.Roles.Any(r => r.Name == "Customer"))
            {
                var role = new IdentityRole("Customer");
                context.Roles.Add(role);
            }

            if (!context.Users.Any(u => u.UserName == "Septem"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "Septem", Email = "frankseptem1026@hotmail.com" };

                manager.Create(user, "Yuquan&1026");
                manager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
