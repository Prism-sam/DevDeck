namespace DevDeck.Core.Models;

// Entidade principal do domínio. Representa um endpoint HTTP que o usuário deseja monitorar.
//
// Propriedades esperadas:
//   Id          – identificador único (Guid)
//   Name        – nome amigável exibido no card do dashboard
//   Url         – URL completa do endpoint (ex: "https://api.exemplo.com/health")
//   Method      – método HTTP (GET, POST, PUT, etc.) — use string ou um enum HttpMethod próprio
//   Headers     – dicionário de headers a enviar na requisição (chave/valor)
//   Body        – corpo JSON opcional a enviar (relevante para POST/PUT)
//   IntervalSeconds – intervalo entre verificações, em segundos (ex: 30)
//   CreatedAt   – data/hora de criação do card
//
// Regras de domínio a implementar:
//   - Url deve ser uma URI absoluta válida
//   - IntervalSeconds deve ser >= 5
//   - Method deve ser um valor HTTP válido
public class EndpointCard
{
    // TODO: implementar propriedades e validações
}
