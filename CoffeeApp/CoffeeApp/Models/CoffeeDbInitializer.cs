using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeApp.Models
{
    public class CoffeeDbInitializer : DropCreateDatabaseAlways<CoffeeContext>
    {
        protected override void Seed(CoffeeContext db)
        {
            db.Coffees.Add(new Coffee { Name = "Cappuccino", Price = 2.3, Volume = 250 });
            db.Coffees.Add(new Coffee { Name = "Americano", Price = 2, Volume = 250 });
            db.Coffees.Add(new Coffee { Name = "Latte", Price = 2.5, Volume = 250 });
            db.Coffees.Add(new Coffee { Name = "Espresso", Price = 1.5, Volume = 100 });
            db.Coffees.Add(new Coffee { Name = "Macchiato", Price = 2.2, Volume = 250 });
            db.Coffees.Add(new Coffee { Name = "Mocha", Price = 2.6, Volume = 250 });

            base.Seed(db);
        }
    }
}