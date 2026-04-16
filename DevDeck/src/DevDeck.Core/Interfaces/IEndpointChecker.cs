using DevDeck.Core.Models;

namespace DevDeck.Core.Interfaces;

// Contrato para o serviço que efetua a chamada HTTP a um endpoint e retorna o resultado.
// Desacopla a lógica de verificação da infraestrutura (HttpClient), facilitando testes unitários.
//
// Métodos esperados:
//   CheckAsync(EndpointCard card, CancellationToken ct) – executa a requisição HTTP conforme as configurações
//                                                         do card (URL, método, headers, body) e retorna um
//                                                         CheckResult preenchido com status, latência e eventuais erros.
//
// Considerações de implementação (para quando você for implementar):
//   - Medir latência com Stopwatch antes/depois do HttpClient.SendAsync
//   - Capturar HttpRequestException e TaskCanceledException (timeout) e mapear para Status = Offline
//   - O limiar de "Degraded" pode ser uma constante ou vir de configuração (ex: > 1000ms)
public interface IEndpointChecker
{
    // TODO: declarar o método CheckAsync
}
