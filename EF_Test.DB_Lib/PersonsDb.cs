using System.IO;
using EF_Test.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Test.DB_Lib
{
    public class PersonsDb : DbContext
    {
        public DbSet<Person> TablePersons { get; set; }
        
        public PersonsDb()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(GetConnectionString("connection_to_db.txt"));
        }

        private static string GetConnectionString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}