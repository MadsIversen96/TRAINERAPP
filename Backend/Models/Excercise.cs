namespace Backend.Models
{
   public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // Foreign key
    public int UserId { get; set; }
    public User User { get; set; } = new User();

    // Navigation properties
    public ICollection<WorkoutTemplateExercise> WorkoutTemplateExercises { get; set; } = new List<WorkoutTemplateExercise>();
}
}