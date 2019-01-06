using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BancoApp.Models;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace BancoApp.Controllers
{
    public class UserLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginClass lc)
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();
            
            conn.Open();
            string sqlquery = "SELECT userName, role FROM Users WHERE userName=@UserName AND password=@Password";
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
            cmd.Parameters.AddWithValue("@UserName", lc.UserName);
            cmd.Parameters.AddWithValue("@Password", lc.Password);

            MySqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read()) {
                TempData["userName"] = lc.UserName.ToString();
                TempData["role"] = sdr["role"].ToString(); 

                return RedirectToAction("Welcome");
            }else{
                ViewData["Message"] = "User Login Failed";
            }
            conn.Close();
            
            return View();
        }

        public IActionResult Welcome()
        {
            string userName = TempData["userName"].ToString();
            string roles = TempData["role"].ToString();
            string[] rolesList = Regex.Split(roles, ",");
            ViewBag.roles = rolesList;
            ViewData["role"] = rolesList;
            ViewData["username"] = userName;
            return View();
        }

        




    }
}