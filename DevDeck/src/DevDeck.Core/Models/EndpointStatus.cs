namespace DevDeck.Core.Models;

// Enumeração que representa o estado atual de um endpoint monitorado.
// - Online: a última verificação retornou dentro do tempo esperado e com status de sucesso
// - Offline: a última verificação falhou (timeout, connection refused, status 5xx, etc.)
// - Degraded: a resposta foi bem-sucedida, mas a latência ultrapassou um limiar aceitável
public enum EndpointStatus
{
    // TODO: definir os valores do enum
}
