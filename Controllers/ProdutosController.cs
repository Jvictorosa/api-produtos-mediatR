using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProjectMediatR.Features.Produtos.Commands;
using ProjectMediatR.Features.Produtos.Queries;

namespace ProjectMediatR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProdutoCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _mediator.Send(new GetAllProdutosQuery());
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var produto = await _mediator.Send(new GetProdutoByIdQuery(id));
            if (produto == null) return NotFound();

            return Ok(produto);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProdutoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteProdutoCommand { Id = id });
            return Ok(result);
        }
    }
}