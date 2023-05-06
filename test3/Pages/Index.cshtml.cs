using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace test3.Pages
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
