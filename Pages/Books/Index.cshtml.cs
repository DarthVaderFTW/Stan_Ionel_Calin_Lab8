using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stan_Ionel_Calin_Lab8.Data;
using Stan_Ionel_Calin_Lab8.Models;

namespace Stan_Ionel_Calin_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Stan_Ionel_Calin_Lab8.Data.Stan_Ionel_Calin_Lab8Context _context;

        public IndexModel(Stan_Ionel_Calin_Lab8.Data.Stan_Ionel_Calin_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
