using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeApp.Models
{
    public class CoffeeContext: DbContext
    {
        public CoffeeContext() : base("DefaultConnection") { }        
        public DbSet<Coffee> Coffees { get; set; }
    }
}