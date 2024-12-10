using Backend.Models;
using Backend.Data;
using Backend.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{
    public class UserRepository : IUserRepository
{
    private readonly TrainingAppContext _context;

    public UserRepository(TrainingAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task CreateUserAsync(User User)
    {
        await _context.Users.AddAsync(User);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User User)
    {
        _context.Users.Update(User);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int id)
    {
        var User = await _context.Users.FindAsync(id);
        if (User != null)
        {
            _context.Users.Remove(User);
            await _context.SaveChangesAsync();
        }
    }
}
}
