using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PageRazor_App1.Data;
using PageRazor_App1.Models;

namespace PageRazor_App1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CustomerDbContext _contex;

        public IndexModel(CustomerDbContext context)
        {
            _contex = context;
        }

        public IList<Customer> Customers { get; set; }

        public async Task OnGetAsync()
        {
            Customers = await _contex.Customers.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var contact = await _contex.Customers.FindAsync(id);
            if(contact != null)
            {
                _contex.Customers.Remove(contact);
                await _contex.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
