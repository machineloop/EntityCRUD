namespace EntityCRUD.Data.Migrations
{
    using EntityCRUD.DataModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityCRUD.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityCRUD.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Customers.AddOrUpdate(
                  c => c.Id,
                  new Customer { Id = 1, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 2, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 3, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 4, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 5, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 6, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 7, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 8, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 9, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) },
                  new Customer { Id = 10, Name = "Joe", Birthday = DateTime.Now.AddYears(-50).AddMonths(-4) }
                );
             context.Orders.AddOrUpdate(
                  c => c.Id,
                  new Order { Id = 1, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 1  },
                  new Order { Id = 2, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 2  },
                  new Order { Id = 3, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 3  },
                  new Order { Id = 4, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 4  },
                  new Order { Id = 5, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 5  },
                  new Order { Id = 6, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 6  },
                  new Order { Id = 7, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 7  },
                  new Order { Id = 8, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 8  },
                  new Order { Id = 9, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 9  },
                  new Order { Id = 10, Description="Something cool", OrderDate= DateTime.Now.AddDays(-10), OrderTotal = 500.00, CustomerId = 10  }
                  );
        }
    }
}
