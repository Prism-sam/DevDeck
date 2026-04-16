using DevDeck.Core.Models;

namespace DevDeck.Core.Interfaces;

// Contrato de persistência para CheckResult.
// Responsável por guardar o histórico de verificações de cada card.
//
// Métodos esperados:
//   AddAsync(CheckResult result)                  – persiste um novo resultado
//   GetByCardIdAsync(Guid cardId, int limit)       – retorna os últimos N resultados de um card, ordenados do mais recente para o mais antigo
//   GetLatestByCardIdAsync(Guid cardId)            – retorna apenas o resultado mais recente de um card (ou null)
public interface ICheckResultRepository
{
    // TODO: declarar os métodos (todos async, retornando Task<T>)
}
