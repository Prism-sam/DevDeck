using System.Net;

namespace DevDeck.Core.Models;
public class CheckResult
{
    public Guid id { get; }
    public Guid cardId { get; }
    public DateTime checkedAt { get; }
    public int? statusCode { get; }

    public double latencyMs { get; }
    public EndpointStatus status { get; }
    public string? errorMessage { get; }

    public CheckResult(Guid cardId, int? statusCode, double latencyMs, string errorMessage)
    {
        id = Guid.NewGuid();
        cardId = cardId;
        checkedAt = DateTime.UtcNow;
        statusCode = statusCode;
        latencyMs = latencyMs;
        errorMessage = errorMessage;


        if (statusCode >= 200 && statusCode < 300 && latencyMs < 1000)
        {
            status = EndpointStatus.Online;

        }
        else if (statusCode >= 200 && statusCode < 300 && latencyMs >= 1000)
        {
            status = EndpointStatus.Degraded;
        }
        else
        {
            status = EndpointStatus.Offline;
        }
    }

}
