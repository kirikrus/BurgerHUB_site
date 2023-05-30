using BurgerHUB.Data.Interfaces;
using BurgerHUB.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerHUB.Pages
{
    public class IndexModel : PageModel
    {
        public string obj = "Сработало";

        public readonly IMenu _Menu;
        public IndexModel(IMenu menu)
        {
            _Menu = menu;
        }
        public IEnumerable<BurgerMenu> Menu;
        public PageResult OnGet()
        {
            Menu = _Menu.BurgersMenu;
            return Page();
        }
    }
}
