using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppPasquali.Model;
using AppPasquali.Repository;

namespace AppPasqualiFront.Pages.PessoaCadastro
{
    public class IndexModel : PageModel
    {
        private readonly AppPasquali.Repository.CadastroContext _context;

        public IndexModel(AppPasquali.Repository.CadastroContext context)
        {
            _context = context;
        }

        public IList<Pessoa> Pessoa { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Pessoa = await _context.Pessoas.ToListAsync();
        }
    }
}
