namespace ConsoleApp8.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int LikeCount { get; set; }

    // Foreign Key
    public int PostId { get; set; }
    public Post Post { get; set; }
}
