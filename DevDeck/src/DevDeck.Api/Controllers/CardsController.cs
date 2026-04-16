using DevDeck.Core.Interfaces;
using DevDeck.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevDeck.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ICardRepository _repository;

        public CardsController(ICardRepository repository)
        {
            _repository = repository;
        }

        // Retorna todos os cards cadastrados
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cards = await _repository.GetAllAsync();
            return Ok(cards);
        }

        // Retorna um card pelo Id, ou 404 se não encontrado
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var card = await _repository.GetByIdAsync(id);
            if (card == null)
                return NotFound();
            return Ok(card);
        }

        // Cria um novo card
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] EndpointCard card)
        {
            await _repository.AddAsync(card);
            return CreatedAtAction(nameof(GetById), new { id = card.Id }, card);
        }

        // Atualiza um card existente, ou 404 se não encontrado
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] EndpointCard card)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return NotFound();
            await _repository.UpdateAsync(card);
            return NoContent();
        }

        // Remove um card pelo Id, ou 404 se não encontrado
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)
                return NotFound();
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}