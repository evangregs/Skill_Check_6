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
        public DbSet<Category> Categories { get; set; }

        // seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                    new Category { CategoryID=1, CategoryName="Action"},
                    new Category { CategoryID=2, CategoryName="Adventure"},
                    new Category { CategoryID=3, CategoryName="Animation"},
                    new Category { CategoryID=4, CategoryName="Chick-flick"},
                    new Category { CategoryID=5, CategoryName="Comedy"},
                    new Category { CategoryID=6, CategoryName="Coming-of-Age"},
                    new Category { CategoryID=7, CategoryName="Documentary"},
                    new Category { CategoryID=8, CategoryName="Drama"},
                    new Category { CategoryID=9, CategoryName="Horror"},
                    new Category { CategoryID=10, CategoryName="Noir"},
                    new Category { CategoryID=11, CategoryName="Romance"},
                    new Category { CategoryID=12, CategoryName="Sci-fi"},
                    new Category { CategoryID=13, CategoryName="Silent"},
                    new Category { CategoryID=14, CategoryName="Thriller"},
                    new Category { CategoryID=15, CategoryName="Western"}
                );

            mb.Entity<MovieSubmission>().HasData(

                    new MovieSubmission
                    {
                        MovieID = 1,
                        CategoryID = 12,
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
                        CategoryID = 6,
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
                        CategoryID = 3,
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
