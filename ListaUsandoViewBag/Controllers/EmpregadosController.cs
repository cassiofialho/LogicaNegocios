using ListaUsandoViewBag.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaUsandoViewBag.Controllers
{
    public class EmpregadosController : Controller
    {
        public IActionResult Index()
        {
            List<Empregado> list = new List<Empregado>()
            {
                new Empregado() {
                    Id = 1,
                    Nome = "Matheus",
                    Endereco = "Avenida Paulista",
                    Cidade = "São Paulo",
                    Pais = "Brasil"
                },
                new Empregado() {
                    Id = 2,
                    Nome = "Cassio",
                    Endereco = "Avenida São judas Tadeu",
                    Cidade = "Rio Grande do Sul",
                    Pais = "Brasil"
                },
                new Empregado() {
                    Id = 3,
                    Nome = "Edilson",
                    Endereco = "Avenida Paulista, 123",
                    Cidade = "São Paulo",
                    Pais = "Brasil"
                },
                new Empregado() {
                    Id = 4,
                    Nome = "Andrea",
                    Endereco = "Avenida Brasil",
                    Cidade = "Rio de Janeiro",
                    Pais = "Brasil"
                },

            };

            ViewBag.model = list;
            ViewBag.Msg = "Acho que deu bom!";
            return View();
        }
    }
}
