using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaWeb.Models.Statistici;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace BibliotecaWeb.Controllers
{
    public class StatisticiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CartiSolicitate()
        {
            var bc = new BibliotecaClient();
            var modelCartiSolicitate = new CartiSolicitateModel();
            modelCartiSolicitate.carti = bc.getCartiSolicitateAsync().Result.ToList();

            return View(modelCartiSolicitate);

        }

        public async Task<IActionResult> AutoriCautati()
        {
            var bc = new BibliotecaClient();
            var autoriCautati = new AutoriCautatiModel();
            autoriCautati.autori = bc.getAutoriCautatiAsync().Result.ToList();

            return View(autoriCautati);

        }

        public async Task<IActionResult> GenuriSolicitate()
        {
            var bc = new BibliotecaClient();
            var genuriSolicitate = new GenuriSolicitateModel();
            genuriSolicitate.genuri = bc.getGenuriCautateAsync().Result.ToList();

            return View(genuriSolicitate);
        }
        public async Task<IActionResult> AlegereCarte()
        {
            var bc = new BibliotecaClient();
            var carteModel = new AlegereCarteModel();
            carteModel.carti = bc.getCartiSolicitateAsync().Result.ToList();
            return View(carteModel);
        }

        public async Task<IActionResult> VizualizareReview(AlegereCarteModel carteModel)
        {
            var bc = new BibliotecaClient();
            var numeCarte = bc.getTitluCarteByIdAsync(carteModel.selectedAnswer).Result;
            var carte = bc.getCarteByNameAsync(numeCarte).Result;
            var reviewsModel = new VizualizareReviewModel();
            reviewsModel.reviews = bc.getReviewsAsync(carte).Result.ToList();

            return View(reviewsModel);
        }

        public async Task<IActionResult> CititoriPerioada([FromForm] CititoriPerioadaModel model)
        {
            var bc = new BibliotecaClient();
            model.cititori = bc.getCititoriPerioadaAsync(model.startTime, model.endTime).Result.ToList();
            return View(model);
        }


    }
}