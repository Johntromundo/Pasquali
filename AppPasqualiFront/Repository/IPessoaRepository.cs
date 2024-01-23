using AppPasquali.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPasquali.Repository
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> GetAllAsync();
        Task<Pessoa> GetByIdAsync(int id);
        Task AddAsync(Pessoa pessoa);
        Task UpdateAsync(Pessoa pessoa);
        Task DeleteAsync(int id);
    }
}
