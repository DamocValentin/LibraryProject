using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace BibliotecaWeb.Controllers
{
    public class RestituireCarteController : Controller
    {
        // GET: RestituireCarte
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RestituireCarte()
        {
            var bc = new BibliotecaClient();
            var numeCarte = Request.Form["numeCarte"].ToString();
            var numeAutor = Request.Form["numeAutor"].ToString();
            var prenumeAutor = Request.Form["prenumeAutor"].ToString();
            var numeCititor = Request.Form["numeCititor"].ToString();
            var prenumeCititor = Request.Form["prenumeCititor"].ToString();
            var textReview = Request.Form["textReview"].ToString();
            await bc.restituireAsync(numeCarte, numeAutor, prenumeAutor, numeCititor, prenumeCititor, textReview);
            return RedirectToAction(nameof(Index));
        }

    }
}