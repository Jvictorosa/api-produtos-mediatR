using MediatR;

namespace ProjectMediatR.Features.Produtos.Commands
{
    public class CreateProdutoCommand : IRequest<int>
    {
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}