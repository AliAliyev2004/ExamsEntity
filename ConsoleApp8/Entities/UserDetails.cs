namespace ConsoleApp8.Entities;

public class UserDetails
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public UserRole Role { get; set; } // Enum (Admin, User)

    
    public User User { get; set; }
}

