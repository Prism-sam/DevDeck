namespace DevDeck.Core.Models;
public class EndpointCard
{
    public Guid Id { get; }
    public string Name { get; }
    public Uri Url { get; }
    public string Method { get; }
    public Dictionary<string, string> Headers { get; }
    public string? Body { get; }
    public double IntervalSeconds { get; }
    public DateTime CreatedAt { get; }

    public EndpointCard(Guid id, string name, Uri url, string method, Dictionary<string, string> headers, string? body, double intervalSeconds)
    {

        var validMethods = new[] { "GET", "POST", "PUT", "DELETE", "PATCH" };

        if (!url.IsAbsoluteUri)
        {
            throw new ArgumentException("Url deve ser uma URI absoluta válida.");

        }
        else if (intervalSeconds < 5)
        {
            throw new ArgumentException("IntervalSeconds deve ser maior ou igual a 5.");
        }
        else if (!validMethods.Contains(method))
        {
            throw new ArgumentException("Método deve ser um valor HTTP válido.");
        }

        Id = Guid.NewGuid();
        Name = name;
        Url = url;
        Method = method.ToString();
        Headers = headers;
        Body = body;
        IntervalSeconds = intervalSeconds;
        CreatedAt = DateTime.UtcNow;

    }

}
