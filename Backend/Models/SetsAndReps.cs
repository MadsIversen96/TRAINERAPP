namespace Backend.Models{
    public class SetsAndReps
{
    public int Id { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }

    // Foreign key
    public int WorkoutTemplateExerciseId { get; set; }
    public WorkoutTemplateExercise? WorkoutTemplateExercise { get; set; }
}
}