using BurgerHUB.Data.Interfaces;
using BurgerHUB.Data.Models;
using BurgerHUB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerHUB.Pages
{
    public class IndexModel : PageModel
    {
        public string obj = "Сработало";
		private readonly DataContext _context;
		public IndexModel(DataContext context)
        {
			_context = context;
		}
        public IEnumerable<BurgerMenu> Menu;
		public PageResult OnGet()
        {
            Menu = _context.BurgerMenus.ToList();
            return Page();
        }
    }
}
