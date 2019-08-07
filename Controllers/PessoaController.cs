using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteGit.Models;

namespace TesteGit.Controllers
{
    public class PessoaController : Controller
    {
        //public IActionResult Index()
        //{
        //    Pessoa p = new Pessoa();
        //    p.Telefone = "Renato";
        //    p.Telefone = "(65) 99239-6322";

        //    return View(p);
        //}

        public IActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Formulario(Pessoa pessoa)
        {
            return View("Pessoa", pessoa);
        }
    }
}
