
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
namespace SupermarketWEB.Pages.Categories
{
  public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;


    public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

    public IList<Category> Category { get; set; } = default!;


    public async Task OnGetAsync()
        {
            if (_context.Categories != null)
            {
                Category = await _context.Categories.ToListAsync();
            }
        }
    }
}

