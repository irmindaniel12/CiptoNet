using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CriptoNet.Controllers
{
    public class HistorialController : Controller
    {
        string Server = @"IRMINE839\IRMIN_INSTANCE";
        string Database = "CriptoNet";
        string Username = "sa";
        string Password = "irmindaniel12";

        Repositorios.HistorialRepositorio Repo;
        public HistorialController()
        {
            string connectionString = $"Data Source={Server};Initial Catalog={Database};User ID={Username};Password={Password}";

            this.Repo =new Repositorios.HistorialRepositorio(connectionString);
        }

        // GET: Historial

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Wallet()
        {
            IEnumerable<Historial> history = this.Repo.GetAll();
            return View(history);
        }

        public ActionResult Eliminar(int id)
        {
            this.Repo.Eliminar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Historial history = this.Repo.Get(id);
            return View(history);
        }

        public ActionResult Trading()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Trading(Historial model)
        {

            model.Fecha = DateTime.Now;
            model.FechaCreacion = DateTime.Now;
            model.Borrado = true;
            this.Repo.Insertar(model);
            return RedirectToAction("Index");
        }

    }
}