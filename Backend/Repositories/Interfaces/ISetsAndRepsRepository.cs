using Backend.Models;

namespace Backend.Repositories.Interfaces
{
    public interface ISetsAndRepsRepository
    {
        Task<IEnumerable<SetsAndReps>> GetAllSetsAndRepssAsync();
        Task<SetsAndReps> GetSetsAndRepsByIdAsync(int id);
        Task CreateSetsAndRepsAsync(SetsAndReps SetsAndReps);
        Task UpdateSetsAndRepsAsync(SetsAndReps SetsAndReps);
        Task DeleteSetsAndRepsAsync(int id);
    }
}