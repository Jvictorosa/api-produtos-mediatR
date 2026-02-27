using MediatR;
using ProjectMediatR.Features.Produtos.Commands;
using ProjectMediatR.Interfaces;

namespace ProjectMediatR.Features.Produtos.Handlers
{
    public class DeleteProdutoHandler : IRequestHandler<DeleteProdutoCommand, bool>
    {
        private readonly IProdutoRepository _repository;

        public DeleteProdutoHandler(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteProdutoCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAsync(request.Id);
        }
    }
}