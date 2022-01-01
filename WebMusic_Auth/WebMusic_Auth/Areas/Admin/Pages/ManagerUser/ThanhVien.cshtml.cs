using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMusic_Auth.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.SqlClient;
using WebMusic_Auth.Data;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebMusic_Auth.Areas.Admin.Pages.ManagerUser
{
    [Authorize(Roles = "Admin")]
    public class ThanhVien : PageModel
    {
        private readonly UserManager<AppUser> _userManager;

        SqlConnection conn;
        public ThanhVien(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            var configuaration = GetConfiguration();
            conn = new SqlConnection(configuaration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }
        public string getUserIdLoggedIn()
        {
            return _userManager.GetUserId(HttpContext.User);
        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }


        const int USER_PER_PAGE = 10;
        public class UserInList : AppUser
        {
            // Liệt kê các Role của User ví dụ: "Admin,Editor" ...
            public string listroles { set; get; }
        }
        public List<UserInList> users;
        public int totalPages { set; get; }

        [TempData] // Sử dụng Session
        public string StatusMessage { get; set; }

        [BindProperty(SupportsGet = true)]
        public int pageNumber { set; get; }

        public class InputModel
        {
            [Required]
            public string ID { set; get; }
            public string Name { set; get; }

            public string[] RoleNames { set; get; }

        }
        [BindProperty]
        public InputModel Input { set; get; }
        public async Task<IActionResult> OnPost()
        {
            var user = await _userManager.FindByIdAsync(Input.ID);
            string ab = Convert.ToString(user);

            if (user == null)
            {
                return NotFound("Không thấy User cần xóa chặn");
            }


            using (conn)
            {
                conn.Open();
                var str = @"UPDATE Users
                        SET LockoutEnd = '2222-12-12', LockoutEnabled = 1
                        WHERE Email = @id";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", ab);
                cmd.ExecuteNonQuery();
            }

            var cuser = await _userManager.GetUserAsync(User);
            //await _userManager.AddToRolesAsync(cuser, new string[] { "Editor" });

            if (pageNumber == 0)
                pageNumber = 1;

            var lusers = (from u in _userManager.Users
                          where u.LockoutEnd == null
                          orderby u.UserName
                          select new UserInList()
                          {
                              Id = u.Id,
                              UserName = u.UserName,
                          });


            int totalUsers = await lusers.CountAsync();


            totalPages = (int)Math.Ceiling((double)totalUsers / USER_PER_PAGE);

            users = await lusers.Skip(USER_PER_PAGE * (pageNumber - 1)).Take(USER_PER_PAGE).ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnGet()
        {

            var cuser = await _userManager.GetUserAsync(User);
            //await _userManager.AddToRolesAsync(cuser, new string[] { "Editor" });

            if (pageNumber == 0)
                pageNumber = 1;

            var lusers = (from u in _userManager.Users
                          orderby u.UserName
                          where u.LockoutEnd == null
                          orderby u.UserName
                          select new UserInList()
                          {
                              Id = u.Id,
                              UserName = u.UserName,
                          });


            int totalUsers = await lusers.CountAsync();


            totalPages = (int)Math.Ceiling((double)totalUsers / USER_PER_PAGE);

            users = await lusers.Skip(USER_PER_PAGE * (pageNumber - 1)).Take(USER_PER_PAGE).ToListAsync();




            return Page();
        }
    }
}
