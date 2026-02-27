using MediatR;
using ProjectMediatR.Features.Produtos.Queries;
using ProjectMediatR.Interfaces;
using ProjectMediatR.Models;

namespace ProjectMediatR.Features.Produtos.Handlers
{
    public class GetProdutoByIdHandler : IRequestHandler<GetProdutoByIdQuery, Produto?>
    {
        private readonly IProdutoRepository _repository;

        public GetProdutoByIdHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Produto?> Handle(GetProdutoByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }
}