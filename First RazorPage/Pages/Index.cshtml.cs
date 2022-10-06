using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace First_RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Akes Ali";
        }
        
        public void OnPost()
        {
            ViewData["Message"] = "Hello" + FullName;
        }
    }
}