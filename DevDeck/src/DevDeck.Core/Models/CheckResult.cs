using System.Net;

namespace DevDeck.Core.Models;
public class CheckResult
{
    public Guid Id { get; }
    public Guid CardId { get; }
    public DateTime CheckedAt { get; }
    public int? StatusCode { get; }
    public double LatencyMs { get; }
    public EndpointStatus Status { get; }
    public string? ErrorMessage { get; }

    public CheckResult(Guid cardId, int? statusCode, double latencyMs, string errorMessage)
    {
        Id = Guid.NewGuid();
        CardId = cardId;
        CheckedAt = DateTime.UtcNow;
        StatusCode = statusCode;
        LatencyMs = latencyMs;
        ErrorMessage = errorMessage;


        if (statusCode >= 200 && statusCode < 300 && latencyMs < 1000)
        {
            Status = EndpointStatus.Online;

        }
        else if (statusCode >= 200 && statusCode < 300 && latencyMs >= 1000)
        {
            Status = EndpointStatus.Degraded;
        }
        else
        {
            Status = EndpointStatus.Offline;
        }
    }

}
