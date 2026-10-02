using Microsoft.EntityFrameworkCore;
using MoviesAdmin.Models;

namespace MoviesAdmin.Data
{
    // DbContext manages connection to database 
    // Tells EF Core which tables (DbSets) should exist
    public class MoviesContext : DbContext
    {
        // Constructor allows EF Core to pass
        // configuration options such as connection string
        public MoviesContext(DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        // DbSet represents Movies table in the database
        // Each Movies object becomes row in Movies table
        public DbSet<Movies> Movies { get; set; } // Movies table
    }
}