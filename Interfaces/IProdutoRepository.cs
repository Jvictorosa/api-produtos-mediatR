using ProjectMediatR.Models;

namespace ProjectMediatR.Interfaces
{
    public interface IProdutoRepository
    {
        Task<int> CreateAsync(Produto produto);
        Task<List<Produto>> GetAllAsync();
        Task<Produto?> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Produto produto);
        Task<bool> DeleteAsync(int id);
    }
}