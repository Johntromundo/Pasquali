using AppPasquali.Model;
using Microsoft.EntityFrameworkCore;

namespace AppPasquali.Repository
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
