using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace my_new_app.SQLite
{
    public class MyAppContext : DbContext
    {
        public DbSet<Objekt> Objekt { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Einheit> Einheit { get; set; }
        public DbSet<Verbrauch> Verbrauch { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }

    public class Objekt
    {
        public int ObjektId { get; set; }
        public string name { get; set; }

        public Person besitzer { get; set; }
        public ICollection<Einheit> einheiten { get; set; }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string name { get; set; }
    }

    public class Einheit
    {
        public int EinheitId { get; set; }
        public string name { get; set; }

        public Person person { get; set; }
        
    }

    public class Verbrauch
    {
        public int VerbrauchId { get; set; }
        public int verbrauch { get; set; }
        
        public Einheit einheit { get; set; }
    }
}