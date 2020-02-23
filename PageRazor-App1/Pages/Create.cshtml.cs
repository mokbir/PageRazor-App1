using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PageRazor_App1.Data;
using PageRazor_App1.Models;

namespace PageRazor_App1.Pages
{
    public class CreateModel : PageModel
    {
        private readonly CustomerDbContext _context;
        public CreateModel(CustomerDbContext context)
        {
            _context = context;

        }   
        [BindProperty]
        public Customer Customer { get; set; }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
