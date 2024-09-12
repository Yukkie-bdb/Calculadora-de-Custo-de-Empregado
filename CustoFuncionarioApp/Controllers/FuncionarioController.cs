using CustoFuncionarioApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustoFuncionarioApp.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var custoFuncionario = funcionario.SalarioBase + funcionario.Beneficio - funcionario.Desconto;

                ViewData["CustoFuncionario"] = custoFuncionario;
            }

            return View("Index", funcionario); // Retorna à view 'Index' com o modelo 'funcionario'
        }
    }
}
