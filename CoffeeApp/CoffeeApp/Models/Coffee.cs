using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeApp.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Volume { get; set; }
    }
}