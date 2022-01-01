using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMusic_Auth.Data;
using WebMusic_Auth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace WebMusic_Auth.Controllers
{
    [ActivatorUtilitiesConstructor]
    public class IndividualController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        SqlConnection conn;
        public IndividualController(UserManager<AppUser> userManager)
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





        /*private readonly MusicContext _context;

        public IndividualController(MusicContext context)
        {
            _context = context;
        }*/
        /*public IActionResult Playlist()
        {
            return View();
        }*/
        public IActionResult Listened()
        {
            return View();
        }
        public IActionResult Love()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Playlist(PlaylistModel m)
        {
            return View(m);
        }*/


        /*public async Task<IActionResult> Index()
        {
            return View(await _context.PlaylistModel.ToListAsync());
        }*/

        //List<PlaylistModel> SL;
        public List<PlaylistModel> LietKePlaylist()
        {
            var UsId = getUserIdLoggedIn();
            List<PlaylistModel> list = new List<PlaylistModel>();
            using (conn)
            {
                conn.Open();
                string str = "SELECT * FROM playlist WHERE UsId=@UsId;";
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.Parameters.AddWithValue("UsId", UsId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PlaylistModel()
                        {
                            PId = Convert.ToInt32(reader["PId"]),
                            UsId = reader["UsId"].ToString(),
                            PName = reader["PName"].ToString(),
                            PDate = Convert.ToDateTime(reader["PDate"]),
                            PStatus = reader["PStatus"].ToString(),
                        });
                    }
                    //SL = list;
                    reader.Close();
                }
                /*string str2 = "SELECT COUNT (*) as SL FROM playlist WHERE PId > 0;";
                SqlCommand cmd2 = new SqlCommand(str2, conn);
                cmd2.Parameters.AddWithValue("UsId", UsId);
                using (var reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var SL = Convert.ToInt32(reader["SL"]);
                        
                    }
                    reader.Close();
                }
                conn.Close();*/
            }
            
            return list;

        }
        public IActionResult Playlist()
        {
            //List<PlaylistModel> list = LietKePlaylist();
            //IndividualController context = HttpContext.RequestServices.GetService(typeof(WebMusic_Auth.Controllers.IndividualController)) as IndividualController;
            /*int SLuong = 0;
            if (SL != null)
                ViewBag.SLuong = SL.Count();
            else
                ViewBag.SLuong = 0;*/
            return View(LietKePlaylist());
        }
        /*private readonly MusicContext _context;

        public IndividualController(MusicContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }*/

        /*public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var PlaylistModel = await _context.PlaylistModels
                .Include(b => b.phong)
                .Include(b => b.tiec)
                .FirstOrDefaultAsync(m => m.matiec == id);
            if (PlaylistModel == null)
            {
                return NotFound();
            }

            return View(PlaylistModel);
        }*/

        /*public IActionResult Delete(int id)
        {
            PlaylistModel pl = new PlaylistModel();
            pl.PName.Remove(id);
            pl.SaveChanges();


            return View();
        }*/

    }
}
