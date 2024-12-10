namespace Backend.Models
{
   public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    // Navigation properties
    public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    public ICollection<WorkoutTemplate> WorkoutTemplates { get; set; } =  new List<WorkoutTemplate>();
}
}