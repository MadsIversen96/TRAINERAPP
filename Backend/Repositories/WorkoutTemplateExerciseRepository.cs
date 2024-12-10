using Backend.Models;
using Backend.Data;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class WorkoutTemplateExerciseRepository : IWorkoutTemplateExerciseRepository
{
    private readonly TrainingAppContext _context;

    public WorkoutTemplateExerciseRepository(TrainingAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WorkoutTemplateExercise>> GetAllWorkoutTemplateExercisesAsync()
    {
        return await _context.WorkoutTemplateExercises.ToListAsync();
    }

    public async Task<WorkoutTemplateExercise> GetWorkoutTemplateExerciseByIdAsync(int id)
    {
        return await _context.WorkoutTemplateExercises.FindAsync(id);
    }

    public async Task CreateWorkoutTemplateExerciseAsync(WorkoutTemplateExercise WorkoutTemplateExercise)
    {
        await _context.WorkoutTemplateExercises.AddAsync(WorkoutTemplateExercise);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateWorkoutTemplateExerciseAsync(WorkoutTemplateExercise WorkoutTemplateExercise)
    {
        _context.WorkoutTemplateExercises.Update(WorkoutTemplateExercise);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteWorkoutTemplateExerciseAsync(int id)
    {
        var WorkoutTemplateExercise = await _context.WorkoutTemplateExercises.FindAsync(id);
        if (WorkoutTemplateExercise != null)
        {
            _context.WorkoutTemplateExercises.Remove(WorkoutTemplateExercise);
            await _context.SaveChangesAsync();
        }
    }
}
}
