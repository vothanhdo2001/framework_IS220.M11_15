using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebMusic_Auth.Areas.Admin.Pages.ManagerUser
{
    [Authorize(Roles = "Admin")]
    public class ChanModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
