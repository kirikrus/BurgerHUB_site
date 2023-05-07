using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerHUB.Pages
{
    public class IndexModel : PageModel
    {
        public static int Counter = 1;

        public void OnGet()
        {
        }

        public PageResult OnPostIncrementCounter()
        {
            Counter++;
            return Page();
        }
    }
}
