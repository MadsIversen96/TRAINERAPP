using Backend.Models;
using Backend.Data;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class ExerciseRepository : IExerciseRepository
{
    private readonly TrainingAppContext _context;

    public ExerciseRepository(TrainingAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Exercise>> GetAllExercisesAsync()
    {
        return await _context.Exercises.ToListAsync();
    }

    public async Task<Exercise> GetExerciseByIdAsync(int id)
    {
        return await _context.Exercises.FindAsync(id);
    }

    public async Task CreateExerciseAsync(Exercise exercise)
    {
        await _context.Exercises.AddAsync(exercise);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateExerciseAsync(Exercise exercise)
    {
        _context.Exercises.Update(exercise);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteExerciseAsync(int id)
    {
        var exercise = await _context.Exercises.FindAsync(id);
        if (exercise != null)
        {
            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();
        }
    }
}
}
