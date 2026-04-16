using DevDeck.Core.Models;

namespace DevDeck.Core.Interfaces;
public interface IEndpointChecker
{
    Task<CheckResult> CheckAsync(EndpointCard card, CancellationToken ct);
}
