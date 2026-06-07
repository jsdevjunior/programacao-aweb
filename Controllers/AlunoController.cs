using Microsoft.AspNetCore.Mvc;

namespace programacao_aweb.Controllers
{
    public class AlunoController : Controller
    {
           public IActionResult Index()
            {
            ViewBag.Nome = "Junior";
            ViewBag.Curso = "ADS";
            ViewBag.Semestre = "1º Semestre";

            return View();
            }
           public IActionResult Detalhes(int id)
            {
            ViewBag.Id = id;

            return View();
            }
    }
}