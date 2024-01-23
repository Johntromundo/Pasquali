using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AppPasquali.Model;
using AppPasquali.Repository;

namespace AppPasqualiFront.Pages.PessoaCadastro
{
    public class CreateModel : PageModel
    {
        private readonly AppPasquali.Repository.CadastroContext _context;

        public CreateModel(AppPasquali.Repository.CadastroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pessoa Pessoa { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pessoas.Add(Pessoa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
