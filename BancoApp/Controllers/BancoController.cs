using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BancoApp.Models;
using System.Data;

namespace BancoApp.Controllers
{
    public class BancoController : Controller
    {
        
        // GET: Banco
        [HttpGet]
        public ActionResult Index()
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;
            MySqlConnection conn = context.GetConnection();
            
            conn.Open();
            DataTable dt = new DataTable();
            string sqlquery = "SELECT * FROM Banco";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlquery, conn);
            sda.Fill(dt);
          
            return View(dt);
        }

        // GET: Banco/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Banco/Create
        public ActionResult Create()
        {
            return View(new BancoModel());
        }

        // POST: Banco/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BancoModel bancoModel)
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();

            conn.Open();
            string sqlquery = "INSERT Into Banco VALUES (@IdBanco, @Nombre, @Direccion, @FechaRegistro)";
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
            cmd.Parameters.AddWithValue("@IdBanco", bancoModel.IdBanco);
            cmd.Parameters.AddWithValue("@Nombre", bancoModel.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", bancoModel.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", bancoModel.FechaRegistro);
            cmd.ExecuteNonQuery();   
            conn.Close();
            return RedirectToAction("Index");
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int id)
        {
            BancoModel bancoModel = new BancoModel();
            DataTable dt = new DataTable();

            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();
            conn.Open();
            string sqlquery = "SELECT * FROM Banco WHERE idBanco = @IdBanco";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlquery, conn);
            sda.SelectCommand.Parameters.AddWithValue("@IdBanco", id);
            sda.Fill(dt);
            if (dt.Rows.Count == 1){
                bancoModel.IdBanco = Convert.ToInt32(dt.Rows[0][0].ToString());
                bancoModel.Nombre = dt.Rows[0][1].ToString();
                bancoModel.Direccion = dt.Rows[0][2].ToString();
                bancoModel.FechaRegistro = (System.DateTime) dt.Rows[0][3];
                return View(bancoModel);
            }
            else {
                return RedirectToAction("Index");
            }


            
        }

        // POST: Banco/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BancoModel bancoModel)
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();

            conn.Open();
            string sqlquery = "Update Banco SET Nombre=@Nombre, Direccion=@Direccion, FechaRegistro=@FechaRegistro WHERE idBanco=@IdBanco";
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);            
            cmd.Parameters.AddWithValue("@IdBanco", bancoModel.IdBanco);
            cmd.Parameters.AddWithValue("@Nombre", bancoModel.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", bancoModel.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", bancoModel.FechaRegistro);
            cmd.ExecuteNonQuery();
            conn.Close();
            return RedirectToAction("Index");
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int id)
        {

            BancoModel bancoModel = new BancoModel();
            DataTable dt = new DataTable();

            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();
            conn.Open();
            string sqlquery = "SELECT * FROM Banco WHERE idBanco = @IdBanco";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlquery, conn);
            sda.SelectCommand.Parameters.AddWithValue("@IdBanco", id);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                bancoModel.IdBanco = Convert.ToInt32(dt.Rows[0][0].ToString());
                bancoModel.Nombre = dt.Rows[0][1].ToString();
                bancoModel.Direccion = dt.Rows[0][2].ToString();
                bancoModel.FechaRegistro = (System.DateTime)dt.Rows[0][3];
                return View(bancoModel);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        // POST: Banco/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();

            conn.Open();
            string sqlquery = "DELETE FROM Banco WHERE idBanco=@IdBanco";
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
            cmd.Parameters.AddWithValue("@IdBanco", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            return RedirectToAction("Index");
        }
    }
}