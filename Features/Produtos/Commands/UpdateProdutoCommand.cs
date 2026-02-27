using MediatR;

namespace ProjectMediatR.Features.Produtos.Commands
{
    public class UpdateProdutoCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}