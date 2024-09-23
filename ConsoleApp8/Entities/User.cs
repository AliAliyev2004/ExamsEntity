namespace ConsoleApp8.Entities;

public class User
{
    public int Id { get; set; }

    // Foreign Key
    public int UserDetailsId { get; set; }
    public UserDetails UserDetails { get; set; }

    // Relation: One-to-Many with Post
    public ICollection<Post> Posts { get; set; }
}
