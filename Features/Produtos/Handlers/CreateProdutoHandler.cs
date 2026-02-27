using MediatR;
using ProjectMediatR.Features.Produtos.Commands;
using ProjectMediatR.Interfaces;
using ProjectMediatR.Models;

namespace ProjectMediatR.Features.Produtos.Handlers
{
    public class CreateProdutoHandler : IRequestHandler<CreateProdutoCommand, int>
    {
        private readonly IProdutoRepository _repository;

        public CreateProdutoHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateProdutoCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto
            {
                Nome = request.Nome,
                Preco = request.Preco,
                Estoque = request.Estoque
            };

            return await _repository.CreateAsync(produto);
        }
    }
}