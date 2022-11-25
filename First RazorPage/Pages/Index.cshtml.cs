
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace First_RazorPage
{
    public class IndexModel : PageModel
    {
        public StringValues FullName;

        public void OnGet()
        {
            FullName = "Akes Ali";
        }

        public void OnPost()
        {
            this.FullName = Request.Form["FullName"];
        }
    }
}