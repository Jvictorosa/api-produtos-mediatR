using MediatR;
using ProjectMediatR.Features.Produtos.Queries;
using ProjectMediatR.Interfaces;
using ProjectMediatR.Models;

namespace ProjectMediatR.Features.Produtos.Handlers
{
    public class GetAllProdutosHandler : IRequestHandler<GetAllProdutosQuery, List<Produto>>
    {
        private readonly IProdutoRepository _repository;

        public GetAllProdutosHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Produto>> Handle(GetAllProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}