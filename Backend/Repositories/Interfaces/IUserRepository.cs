using Backend.Models;

namespace Backend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int id);
        Task CreateUserAsync(User User);
        Task UpdateUserAsync(User User);
        Task DeleteUserAsync(int id);
    }
}