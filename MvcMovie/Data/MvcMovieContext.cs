using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : IdentityDbContext<MvcMovieUser>
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieUser> Users { get; set; }
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MvcMovie.Models.Review> Review { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Movie and Review
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Movie)         // A review belongs to one movie
                .WithMany(m => m.Reviews)     // A movie can have many reviews
                .HasForeignKey(r => r.MovieId)  // Foreign key
                .IsRequired();                // MovieId is required in a review

            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)         // A review belongs to one user
                .WithMany(m => m.Reviews)     // A user can have many reviews
                .HasForeignKey(r => r.UserId)  // Foreign key
                .IsRequired();                // UserId is required in a review
        }
    }
}
