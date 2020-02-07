using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportApplication.Data;
using SportApplication.Models;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new SportContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SportContext>>());

            // Look for any contestants.
            if (context.Contestants.Any())
            {
                return;   // DB has been seeded
            }

            context.Contestants.AddRange(

                 new Contestant {  FirstName = "Carson", LastName = "Alexander", Age = 15 },
                 new Contestant {  FirstName = "vojce", LastName = "Gruevski", Age = 21 },
                 new Contestant {  FirstName = "John", LastName = "rown", Age = 16 },
                 new Contestant {  FirstName = "Ivan", LastName = "Dzogani", Age = 25 },
                 new Contestant {  FirstName = "Alexa", LastName = "Google", Age = 17 },
                 new Contestant {  FirstName = "Sean", LastName = "Stalone", Age = 11 },
                 new Contestant {  FirstName = "Dime", LastName = "Abramovic", Age = 19 }

            );

            context.SaveChanges();

            // Look for any sports.
            if (context.Sports.Any())
            {
                return;   // DB has been seeded
            }

            context.Sports.AddRange(
                new Sport { SportID = 1, SportTitle = "Football", Description = "This is description for Football" },
                new Sport { SportID = 2, SportTitle = "Rugby", Description = "This is description for Rugby" },
                new Sport { SportID = 3, SportTitle = "Basketball", Description = "This is description for Basketball" },
                new Sport { SportID = 4, SportTitle = "Tennis", Description = "This is description for Tennis" }


            );

            context.SaveChanges();
        }


    }
}