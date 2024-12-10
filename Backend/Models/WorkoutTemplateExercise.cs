namespace Backend.Models{
   public class WorkoutTemplateExercise
{
    public int Id { get; set; }

    // Foreign keys
    public int WorkoutTemplateId { get; set; }
    public WorkoutTemplate WorkoutTemplate { get; set; } = new WorkoutTemplate();

    public int ExerciseId { get; set; }
    public Exercise Exercise { get; set; } = new Exercise();

    // Navigation properties
    public ICollection<SetsAndReps> SetsAndReps { get; set; } = new List<SetsAndReps>();
}
}