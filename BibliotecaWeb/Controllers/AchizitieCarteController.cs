using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using BibliotecaWeb.Models;

namespace BibliotecaWeb.Controllers
{
    public class AchizitieCarteController : Controller
    {
        //GET: AchizitieCarte
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Achizitionare()
        {
            var bc = new BibliotecaClient();
            var descrieGen = Request.Form["descrieGen"].ToString();
            var numar_de_inserari = Convert.ToInt16(Request.Form["numar_de_inserari"]);
            var numeAutor = Request.Form["numeAutor"].ToString();
            var prenumeAutor = Request.Form["prenumeAutor"].ToString();
            var titluCarte = Request.Form["titluCarte"].ToString();
            await bc.achizitieAsync(titluCarte, descrieGen, numeAutor, prenumeAutor, numar_de_inserari);

            return RedirectToAction(nameof(Index));
        }


    }
}