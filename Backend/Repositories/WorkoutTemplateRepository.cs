using Backend.Models;
using Backend.Data;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class WorkoutTemplateRepository : IWorkoutTemplateRepository
{
    private readonly TrainingAppContext _context;

    public WorkoutTemplateRepository(TrainingAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WorkoutTemplate>> GetAllWorkoutTemplatesAsync()
    {
        return await _context.WorkoutTemplates.ToListAsync();
    }

    public async Task<WorkoutTemplate> GetWorkoutTemplateByIdAsync(int id)
    {
        return await _context.WorkoutTemplates.FindAsync(id);
    }

    public async Task CreateWorkoutTemplateAsync(WorkoutTemplate WorkoutTemplate)
    {
        await _context.WorkoutTemplates.AddAsync(WorkoutTemplate);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateWorkoutTemplateAsync(WorkoutTemplate WorkoutTemplate)
    {
        _context.WorkoutTemplates.Update(WorkoutTemplate);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteWorkoutTemplateAsync(int id)
    {
        var WorkoutTemplate = await _context.WorkoutTemplates.FindAsync(id);
        if (WorkoutTemplate != null)
        {
            _context.WorkoutTemplates.Remove(WorkoutTemplate);
            await _context.SaveChangesAsync();
        }
    }
}
}
