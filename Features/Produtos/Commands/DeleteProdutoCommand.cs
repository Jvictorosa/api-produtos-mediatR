using MediatR;

namespace ProjectMediatR.Features.Produtos.Commands
{
    public class DeleteProdutoCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}