using Backend.Models;

namespace Backend.Repositories.Interfaces
{
    public interface IWorkoutTemplateRepository
    {
        Task<IEnumerable<WorkoutTemplate>> GetAllWorkoutTemplatesAsync();
        Task<WorkoutTemplate> GetWorkoutTemplateByIdAsync(int id);
        Task CreateWorkoutTemplateAsync(WorkoutTemplate WorkoutTemplate);
        Task UpdateWorkoutTemplateAsync(WorkoutTemplate WorkoutTemplate);
        Task DeleteWorkoutTemplateAsync(int id);
    }
}
