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
    public class DeleteModel : PageModel
    {
        private readonly AppPasquali.Repository.CadastroContext _context;

        public DeleteModel(AppPasquali.Repository.CadastroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas.FirstOrDefaultAsync(m => m.Id == id);

            if (pessoa == null)
            {
                return NotFound();
            }
            else
            {
                Pessoa = pessoa;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa != null)
            {
                Pessoa = pessoa;
                _context.Pessoas.Remove(Pessoa);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
