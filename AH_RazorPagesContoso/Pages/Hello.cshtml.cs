using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AH_RazorPagesContoso.Pages
{
    public class HelloModel : PageModel
    {
        public string UserName { get; set; }
       
        public void OnGet()
        {
            UserName = null;
        }

        public void OnPost()
        {
            UserName = Request.Form["UserName"];
        }
    }
}