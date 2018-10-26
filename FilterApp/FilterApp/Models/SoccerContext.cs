using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilterApp.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
    public class SoccerDbInitializer : DropCreateDatabaseAlways<SoccerContext>
    {
        protected override void Seed(SoccerContext db)
        {
            Team t1 = new Team { Name = "Barcelona" };
            Team t2 = new Team { Name = "Real Madrid" };
            db.Teams.Add(t1);
            db.Teams.Add(t2);
            db.SaveChanges();
            Player pl1 = new Player { Name = "Ronaldo", Age = 31, Position = "Forward", Team = t2 };
            Player pl2 = new Player { Name = "Messi", Age = 28, Position = "Forward", Team = t1 };
            Player pl3 = new Player { Name = "Xavi", Age = 34, Position = "Midfielder", Team = t1 };
            Player pl4 = new Player { Name = "Bale", Age = 25, Position = "Midfielder", Team = t2 };
            Player pl5 = new Player { Name = "Neymar", Age = 22, Position = "Forward", Team = t1 };
            Player pl6 = new Player { Name = "Rodriguez", Age = 26, Position = "Midfielder", Team = t2 };
            db.Players.AddRange(new List<Player> { pl1, pl2, pl3, pl4, pl5, pl6 });
            db.SaveChanges();
        }
    }
    

}