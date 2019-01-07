using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BancoApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace BancoApp.Controllers
{
    public class SucursalController : Controller
    {

        // GET: Sucursal
        [HttpGet]
        public ActionResult Index()
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;
            MySqlConnection conn = context.GetConnection();

            conn.Open();
            DataTable dt = new DataTable();
            string sqlquery = "SELECT * FROM Sucursal";
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlquery, conn);
            sda.Fill(dt);

            return View(dt);
        }

        // GET: Sucursal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sucursal/Create
        public ActionResult Create(int id)
        {
            return View(new SucursalModel());
        }

        // POST: Sucursal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.SucursalModel sucursalModel, int id)
        {
            BancoAppContext context = HttpContext.RequestServices.GetService(typeof(BancoApp.Models.BancoAppContext)) as BancoAppContext;

            MySqlConnection conn = context.GetConnection();

            conn.Open();
            string sqlquery = "INSERT Into Sucursal (nombre, direccion, fechaRegistro, Banco_idBanco) VALUES ( @Nombre, @Direccion, @FechaRegistro, @Banco_idBanco)";
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
            //cmd.Parameters.AddWithValue("@IdSucursal", sucursalModel.IdSucursal);
            cmd.Parameters.AddWithValue("@Nombre", sucursalModel.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", sucursalModel.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", sucursalModel.FechaRegistro);
            cmd.Parameters.AddWithValue("@Banco_idBanco", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            return RedirectToAction("Details", "Banco", new {@id = id});

        }

        // GET: Sucursal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sucursal/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sucursal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sucursal/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}