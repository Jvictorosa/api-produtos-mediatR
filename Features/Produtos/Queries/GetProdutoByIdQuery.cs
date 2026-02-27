using MediatR;
using ProjectMediatR.Models;

namespace ProjectMediatR.Features.Produtos.Queries
{
    public class GetProdutoByIdQuery : IRequest<Produto?>
    {
        public int Id { get; }

        public GetProdutoByIdQuery(int id)
        {
            Id = id;
        }
    }
}