using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class BigChillinContext : DbContext
    {
        //constructor
        public BigChillinContext(DbContextOptions<BigChillinContext> choices) : base (choices)
        {
            // leave blank for now
        }

        public DbSet<MovieSubmission> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieSubmission>().HasData(

                    new MovieSubmission
                    {
                        MovieID = 1,
                        Category = "Sci-Fi",
                        Title = "Interstellar",
                        Year = 2014,
                        Director = "Christopher Nolan",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "Masterpiece"
                    },
                    new MovieSubmission
                    {
                        MovieID = 2,
                        Category = "Romance/Satire",
                        Title = "The Graduate",
                        Year = 1967,
                        Director = "Mike Nichols",
                        Rating = "PG",
                        Edited = false,
                        LentTo = "",
                        Notes = "Hello Darkness"
                    },
                    new MovieSubmission
                    {
                        MovieID = 3,
                        Category = "Adventure",
                        Title = "Puss in Boots: The Last Wish",
                        Year = 2022,
                        Director = "Joel Crawford",
                        Rating = "PG",
                        Edited = false,
                        LentTo = "",
                        Notes = "The most epic tale we've seen since Homer's 'Odyssey'"
                    }
                );
        }
    }
}
