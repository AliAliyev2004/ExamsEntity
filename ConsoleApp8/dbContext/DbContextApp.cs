using ConsoleApp8.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp8.dbContext;

public class DbContextApp:DbContext
{
    public DbSet<UserDetails> UserDetails { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        modelBuilder.Entity<User>()
            .HasOne(u => u.UserDetails)
            .WithOne(ud => ud.User)
            .HasForeignKey<User>(u => u.UserDetailsId);

        // One-to-Many relationship between User and Post
        modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId);

        // One-to-Many relationship between Post and Comment
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.Post)
            .WithMany(p => p.Comments)
            .HasForeignKey(c => c.PostId);
    }

    // Configure connection string (example)
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=ALI\\SQLEXPRESS;Initial Catalog=DBB;Trusted_Connection=True;Trust Server Certificate=True");
    }
}
