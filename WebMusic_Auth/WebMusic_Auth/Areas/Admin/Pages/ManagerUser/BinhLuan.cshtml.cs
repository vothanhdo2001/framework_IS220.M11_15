using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebMusic_Auth.Areas.Admin.Pages.ManagerUser
{
    public class BinhLuanModel : PageModel
    {
        [Authorize(Roles = "Admin")]
        public void OnGet()
        {
        }
    }
}
