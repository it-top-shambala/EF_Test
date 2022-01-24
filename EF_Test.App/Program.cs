using System;
using System.Linq;
using EF_Test.DB_Lib;

namespace EF_Test.App
{
    internal static class Program
    {
        private static void Main()
        {
            var db = new PersonsDb();
            var persons = db.TablePersons;

            /*db.TablePersons.Add(new Person
            {
                FirstName = "Anonim",
                LastName = "Anonimus",
                Age = 0,
                IsDelete = true
            });
            db.SaveChanges();*/
            
            foreach (var p in persons.ToList())
            {
                Console.WriteLine($"{p.Id}: {p.LastName} {p.FirstName}, {p.Age}");
            }
        }
    }
}