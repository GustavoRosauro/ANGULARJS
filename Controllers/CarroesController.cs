using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PraticandoAngular.Models;

namespace PraticandoAngular.Controllers
{
    public class CarroesController : Controller
    {
        private PraticandoAngularContext db = new PraticandoAngularContext();
        Carro carro = new Carro();

        // GET: Carroes
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Add(string marca, string modelo)
        {
            carro.Marca = marca;
            carro.Modelo = modelo;
            db.Carroes.Add(carro);
            db.SaveChanges();
            return Json("Inserido");
        }
        public JsonResult BuscaDados()
        {
            return Json(db.Carroes.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}

