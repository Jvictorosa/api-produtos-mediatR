using MediatR;
using ProjectMediatR.Models;

namespace ProjectMediatR.Features.Produtos.Queries
{
    public class GetAllProdutosQuery : IRequest<List<Produto>>
    {
    }
}