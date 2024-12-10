using Backend.Models;
using Backend.Data;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class SetsAndRepsRepository : ISetsAndRepsRepository
{
    private readonly TrainingAppContext _context;

    public SetsAndRepsRepository(TrainingAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SetsAndReps>> GetAllSetsAndRepssAsync()
    {
        return await _context.SetsAndReps.ToListAsync();
    }

    public async Task<SetsAndReps> GetSetsAndRepsByIdAsync(int id)
    {
        return await _context.SetsAndReps.FindAsync(id);
    }

    public async Task CreateSetsAndRepsAsync(SetsAndReps SetsAndReps)
    {
        await _context.SetsAndReps.AddAsync(SetsAndReps);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateSetsAndRepsAsync(SetsAndReps SetsAndReps)
    {
        _context.SetsAndReps.Update(SetsAndReps);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteSetsAndRepsAsync(int id)
    {
        var SetsAndReps = await _context.SetsAndReps.FindAsync(id);
        if (SetsAndReps != null)
        {
            _context.SetsAndReps.Remove(SetsAndReps);
            await _context.SaveChangesAsync();
        }
    }
}
}
