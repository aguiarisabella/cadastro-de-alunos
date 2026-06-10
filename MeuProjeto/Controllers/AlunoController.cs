using CadastroAlunos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunos.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensagem = "Aluno cadastrado com sucesso!";
                return View("Confirmacao", aluno);
            }

            return View(aluno);
        }
    }
}