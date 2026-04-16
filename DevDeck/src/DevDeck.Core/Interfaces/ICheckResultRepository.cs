using DevDeck.Core.Models;

namespace DevDeck.Core.Interfaces;
public interface ICheckResultRepository
{
    Task AddAsync(CheckResult result);

    Task<IEnumerable<CheckResult>> GetByCardIdAsync(Guid cardId, int limit);
    Task<CheckResult?> GetLatestByCardIdAsync(Guid cardId);

}
