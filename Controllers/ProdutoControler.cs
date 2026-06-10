using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> nomes = new List<string>
            {
                "Caneta",
                "Caderno",
                "Mochila",
                "Tênis",
                "Camisa"
            };

            List<double> precos = new List<double>
            {
                5.90,
                35.00,
                150.00,
                299.90,
                89.90
            };

            ViewBag.Nomes = nomes;
            ViewBag.Precos = precos;

            return View();
        }
    }
}