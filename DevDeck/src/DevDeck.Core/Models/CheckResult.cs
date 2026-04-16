namespace DevDeck.Core.Models;

// Representa o resultado de uma única verificação feita contra um EndpointCard.
// Uma instância é criada a cada vez que o BackgroundService dispara uma checagem.
//
// Propriedades esperadas:
//   Id            – identificador único (Guid)
//   CardId        – FK para o EndpointCard que originou esta verificação
//   CheckedAt     – timestamp exato da verificação
//   StatusCode    – HTTP status code retornado (ex: 200, 404, 503); null se houve erro de conexão
//   LatencyMs     – latência da resposta em milissegundos
//   Status        – valor de EndpointStatus calculado a partir do StatusCode e LatencyMs
//   ErrorMessage  – mensagem de erro em caso de falha de rede/timeout; null caso contrário
//
// Regra de domínio:
//   - Status deve ser derivado: Online se 2xx e latência ok, Degraded se latência alta, Offline caso contrário
public class CheckResult
{
    // TODO: implementar propriedades
}
