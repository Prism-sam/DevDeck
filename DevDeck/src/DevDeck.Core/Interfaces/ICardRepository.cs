using DevDeck.Core.Models;

namespace DevDeck.Core.Interfaces;

// Contrato de persistência para EndpointCard.
// A implementação inicial será em memória (lista/dicionário); futuramente pode ser trocada por EF Core sem alterar o domínio.
//
// Métodos esperados:
//   GetAllAsync()              – retorna todos os cards cadastrados
//   GetByIdAsync(Guid id)      – retorna um card pelo Id, ou null se não encontrado
//   AddAsync(EndpointCard card)    – persiste um novo card
//   UpdateAsync(EndpointCard card) – atualiza um card existente
//   DeleteAsync(Guid id)       – remove um card pelo Id
public interface ICardRepository
{
    // TODO: declarar os métodos (todos async, retornando Task<T>)
}
