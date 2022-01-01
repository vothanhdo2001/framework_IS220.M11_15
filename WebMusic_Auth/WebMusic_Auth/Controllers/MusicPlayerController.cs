using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebMusic_Auth.Data;
using WebMusic_Auth.Models;

namespace WebMusic_Auth.Controllers
{
    public class MusicPlayerController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        
        SqlConnection conn;
/*        public MusicPlayerController()
        {
            var configuaration = GetConfiguration();
            conn = new SqlConnection(configuaration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }*/
        public MusicPlayerController(UserManager<AppUser> userManager)
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

        public IActionResult Index()
        {
            return View();
        }
        public List<Object> sqlGetPlaylistDetail(int PId)
        {
            List<Object> list = new List<Object>();
            //var constr = 
            using (conn)
            {
                conn.Open();
                string query = "Select * From playlistDetail join song on playlistDetail.MId = song.MId " +
                                "join songDetail on songDetail.MId = song.MId " +
                                "join singer on singer.SiId = songDetail.SiId " +
                                "Where playlistDetail.PId = @PId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("PId", PId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            PId = Convert.ToInt32(reader["PId"]),
                            MId = Convert.ToInt32(reader["MId"]),
                            Song = reader["Song"].ToString(),
                            Lyrics = reader["Lyrics"].ToString(),
                            Files = reader["Files"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            SiId = Convert.ToInt32(reader["SiId"]),
                            SiName = reader["SiName"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        [HttpPost]
        public JsonResult GetPlaylistDetail(int PId)
        {

            //MusicContext context = HttpContext.RequestServices.GetService(typeof(WebMusic_Auth.Data.MusicContext)) as MusicContext;
            //var listSong = new List<SongModel>();
            var data = sqlGetPlaylistDetail(PId);
            return Json(data);
        }



        public List<Object> sqlGetCommentsSong(int MId)
        {
            List<Object> list = new List<Object>();
            using (conn)
            {
                conn.Open();
                string query = "Select CoId, UsId, Content, NickName, Photo from comments " +
                                "join Users on Users.Id = comments.UsId Where MId = @MId;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MId", MId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            CoId = Convert.ToInt32(reader["CoId"]),
                            UsId = reader["UsId"],
                            NickName = reader["NickName"].ToString(),
                            Content = reader["Content"].ToString(),
                            Photo = reader["Photo"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        [HttpGet]
        public JsonResult GetCommentsSong(int MId)
        {
            var data = sqlGetCommentsSong(MId);
            return Json(data);
        }


        public List<Object> sqlGetPlaylists(string UsId)
        {
            List<Object> list = new List<Object>();
            using (conn)
            {
                conn.Open();
                string query = "Select * From playlist Where UsId = @UsId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("UsId", UsId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            PId = Convert.ToInt32(reader["PId"]),
                            PName = reader["PName"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        [HttpGet]
        public JsonResult GetPlaylists()
        {
            string UsId = getUserIdLoggedIn();
            //MusicContext context = HttpContext.RequestServices.GetService(typeof(WebMusic_Auth.Data.MusicContext)) as MusicContext
            var data = sqlGetPlaylists(UsId);
            return Json(data);
        }


        [HttpPost]
        public void AddCommentSong(int MId, string Content)
        {
            string UsId = getUserIdLoggedIn();
            using (conn)
            {
                conn.Open();
                string query = "INSERT INTO comments(UsId, MId, Content) VALUES(@UsId,@MId,@Content)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("UsId", UsId);
                cmd.Parameters.AddWithValue("MId", MId);
                cmd.Parameters.AddWithValue("Content", Content);
                var Reader = cmd.ExecuteNonQuery();
                if (Reader > 0)
                {
                    Console.Write("Insert sucessed");
                }
                conn.Close();
            }
        }

        [HttpPost]
        public void AddLoveSong(int MId)
        {
            string UsId = getUserIdLoggedIn();
            using (conn)
            {
                conn.Open();
                string query = "INSERT INTO loveDetail(UsId, MId) VALUES(@UsId, @MId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("UsId", UsId);
                cmd.Parameters.AddWithValue("MId", MId);
                var Reader = cmd.ExecuteNonQuery();
                if (Reader > 0)
                {
                    Console.Write("Insert sucessed");
                }
                conn.Close();
            }
        }

        [HttpPost]
        public void RemoveLoveSong(int MId)
        {
            string UsId = getUserIdLoggedIn();
            using (conn)
            {
                conn.Open();
                string query = "DELETE From loveDetail Where UsId = @UsId and MId = @MId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("UsId", UsId);
                cmd.Parameters.AddWithValue("MId", MId);
                var Reader = cmd.ExecuteNonQuery();
                if (Reader > 0)
                {
                    Console.Write("Delete sucessed");
                }
                conn.Close();
            }
        }
        public bool GetStatusLoveSong(int MId)
        {
            string UsId = getUserIdLoggedIn();
            using (conn)
            {
                conn.Open();
                string query = "Select * From loveDetail Where UsId = @UsId and MId = @MId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("UsId", UsId);
                cmd.Parameters.AddWithValue("MId", MId);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                    
                }
                
            }
        }

        [HttpPost]
        public void AddSongIntoPlaylist(int PId, int MId)
        {
            using (conn)
            {
                conn.Open();
                string query = "Select * From playlistDetail Where PId = @PId and MId = @MId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("PId", PId);
                cmd.Parameters.AddWithValue("MId", MId);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    using (conn)
                    {
                        conn.Open();
                        query = "INSERT INTO playlistDetail(PId, MId) VALUES(@PId, @MId)";
                        SqlCommand comand = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("PId", PId);
                        cmd.Parameters.AddWithValue("MId", MId);
                        var Reader = comand.ExecuteNonQuery();
                        if (Reader > 0)
                        {
                            Console.Write("Insert sucessed");
                        }
                        conn.Close();
                    }
                }   
                
            } 
        }



        public ActionResult SongDetail(int MId)
        {
            using (conn)
            {
                conn.Open();
                string query = "Select * From song join categoryDetail on song.MId = categoryDetail.MId " +
                               "join songDetail on songDetail.MId = song.MId " +
                               "join singer on singer.SiId = songDetail.SiId " +
                               "join category on categoryDetail.CaId = category.CaId Where song.MId = @MId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("MId", MId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewBag.Song = reader["Song"].ToString();
                        ViewBag.Nviews = Convert.ToInt32(reader["Nviews"]);
                        ViewBag.Photo = reader["Photo"].ToString();
                        ViewBag.CaName = reader["CaName"].ToString();
                        ViewBag.SiName = reader["SiName"].ToString();
                    }
                    reader.Close();

                }
                conn.Close();

            }
            return View();
        }

        public ActionResult SingerDetail(int SiId)
        {
            List<SongModel> songs = new List<SongModel>();
            using (conn)
            {
                conn.Open();
                string query = "Select SiName, singer.Photo, song.Photo, Story, Song, song.MId From singer join songDetail on songDetail.SiId = singer.SiId " +
                               "join song on song.MId = songDetail.MId Where singer.SiId = @SiId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("SiId", SiId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewBag.SiName = reader.GetString(0);
                        ViewBag.SiPhoto = reader.GetString(1);
                        ViewBag.Story = reader.GetString(3);
                        songs.Add(new SongModel() {
                            Song = reader.GetString(4),
                            Photo = reader.GetString(2),
                            MId = reader.GetInt32(5)
                        });
                    }
                    reader.Close();

                }
                conn.Close();

            }
            return View(songs);
        }
    }
}
