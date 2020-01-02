using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaWeb.Models.ImprumutCarte;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace BibliotecaWeb.Controllers
{
    public class ImprumutCarteController : Controller
    {
        // GET: ImprumutCarte
        public ActionResult Index()
        {
            return View();
        }
        
        public async Task<ActionResult> AlegereGen()
        {
            var bc = new BibliotecaClient();
            var numeCititor = Request.Form["numeCititor"].ToString();
            var prenumeCititor = Request.Form["prenumeCititor"].ToString();
            var adresaCititor = Request.Form["adresaCititor"].ToString();
            var emailCititior = Request.Form["emailCititior"].ToString();

            var modelAlegereGen = new AlegereGenModel();

            modelAlegereGen.cititorId = await bc.getCititorIdAsync(numeCititor, prenumeCititor, adresaCititor, emailCititior);
            var genuri = await bc.getAllGensAsync();
            var stare = await bc.getStareAsync(modelAlegereGen.cititorId);
            modelAlegereGen.stare = stare;
            modelAlegereGen.genuri = genuri.ToList();

            return View(modelAlegereGen);

        }

        public async Task<ActionResult> AlegereCarte(AlegereGenModel modelAlegereGen)
        {
            var bc = new BibliotecaClient();

            var carti = await bc.getCartiDupaGenAsync(modelAlegereGen.selectedAnswer);

            var modelAlegereCarte = new AlegereCarteModel();
            modelAlegereCarte.carti = carti.ToList();
            modelAlegereCarte.cititorId = modelAlegereGen.cititorId;
            return View(modelAlegereCarte);
        }

        [HttpPost]
        public async Task<ActionResult> ImprumutCarte(AlegereCarteModel modelAlegereCarte)
        {
            var bc = new BibliotecaClient();
            var genId = await bc.getGenIdByCarteIdAsync(modelAlegereCarte.selectedAnswer);
            var genCarte = await bc.getGenCarteDescriereAsync(genId);
            var titluCarte = await bc.getTitluCarteByIdAsync(modelAlegereCarte.selectedAnswer);
            var cititor = await bc.GetCititorByIdAsync(modelAlegereCarte.cititorId);
            await bc.realizareImprumutAsync(genCarte, titluCarte, cititor.Nume, cititor.Prenume, cititor.Adresa, cititor.Email);

            return View(nameof(Index));
        }
    }
}