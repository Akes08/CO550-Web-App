using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace First_RazorPage.Pages
{
    public class HelloWorldModel : PageModel
    {
        public StringValues name;

        public void OnGet()
        {
            name = "Akes Ali";
        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}