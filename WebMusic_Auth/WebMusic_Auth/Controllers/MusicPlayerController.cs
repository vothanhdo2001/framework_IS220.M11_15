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
        SqlConnection conn;
        public MusicPlayerController()
        {
            var configuaration = GetConfiguration();
            conn = new SqlConnection(configuaration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
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
        [HttpGet]
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
                            UsId = Convert.ToInt32(reader["UsId"]),
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
        [HttpPost]
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
        [HttpPost]
        public JsonResult GetPlaylists(string UsId)
        {
            //MusicContext context = HttpContext.RequestServices.GetService(typeof(WebMusic_Auth.Data.MusicContext)) as MusicContext
            var data = sqlGetPlaylists(UsId);
            return Json(data);
        }


        [HttpPost]
        public void AddCommentSong(string UsId, int MId, string Content)
        {
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
        public void AddLoveSong(string UsId, int MId)
        {
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
        public void RemoveLoveSong(string UsId, int MId)
        {
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


    }
}
