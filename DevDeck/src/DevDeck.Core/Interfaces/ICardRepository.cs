using DevDeck.Core.Models;

namespace DevDeck.Core.Interfaces;

public interface ICardRepository
{
    Task<IEnumerable<EndpointCard>> GetAllAsync();
    Task<EndpointCard?> GetByIdAsync(Guid id);

    Task AddAsync(EndpointCard card);

    Task DeleteAsync(Guid id);
    Task UpdateAsync(EndpointCard card);
}
