using System.Xml.Linq;

namespace ConsoleApp8.Entities;

public class Post
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int LikeCount { get; set; }

    // Relation: One-to-Many with Comment
    public ICollection<Comment> Comments { get; set; }

    // Foreign Key
    public int UserId { get; set; }
    public User User { get; set; }
}
