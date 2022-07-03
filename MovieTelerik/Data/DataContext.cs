using MovieTelerik.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieTelerik.Data
{
    public class DataContext : DbContext
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Movie>()
            //    .HasOne(x => x.Genre)
            //    .WithMany(x => x.Movies)
            //    .HasForeignKey(x => x.GenreId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Movie>()
            //    .HasMany(x => x.Genres)
            //    .WithOne(op => op.Movie)
            //    .HasForeignKey(@"MovieId")
            //    .IsRequired(true);

            //builder.Entity<Genre>()
            //    .HasOne(x => x.Movie)
            //    .WithMany(op => op.Genres)
            //    .HasForeignKey(@"MovieId")
            //    .IsRequired(true);

           
        }


        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }


        

    }
}
