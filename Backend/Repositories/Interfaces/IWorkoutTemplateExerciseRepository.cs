using Backend.Models;

namespace Backend.Repositories.Interfaces
{
    public interface IWorkoutTemplateExerciseRepository
    {
        Task<IEnumerable<WorkoutTemplateExercise>> GetAllWorkoutTemplateExercisesAsync();
        Task<WorkoutTemplateExercise> GetWorkoutTemplateExerciseByIdAsync(int id);
        Task CreateWorkoutTemplateExerciseAsync(WorkoutTemplateExercise WorkoutTemplateExercise);
        Task UpdateWorkoutTemplateExerciseAsync(WorkoutTemplateExercise WorkoutTemplateExercise);
        Task DeleteWorkoutTemplateExerciseAsync(int id);
    }
}