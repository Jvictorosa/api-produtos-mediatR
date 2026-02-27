using MediatR;
using ProjectMediatR.Features.Produtos.Commands;
using ProjectMediatR.Interfaces;
using ProjectMediatR.Models;

namespace ProjectMediatR.Features.Produtos.Handlers
{
    public class UpdateProdutoHandler : IRequestHandler<UpdateProdutoCommand, bool>
    {
        private readonly IProdutoRepository _repository;

        public UpdateProdutoHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateProdutoCommand request, CancellationToken cancellationToken)
        {
            var produtoExistente = await _repository.GetByIdAsync(request.Id);

            if (produtoExistente == null)
                return false;

            produtoExistente.Nome = request.Nome;
            produtoExistente.Preco = request.Preco;
            produtoExistente.Estoque = request.Estoque;

            return await _repository.UpdateAsync(produtoExistente);
        }
    }
}