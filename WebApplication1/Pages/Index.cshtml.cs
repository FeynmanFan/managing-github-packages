namespace WebApplication1.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public string HeaderText
        {
            get
            {
                var lib = new OurWebApp.OurLibrary.OurClass();

                return lib.HeaderText;
            }
        }
    }
}
