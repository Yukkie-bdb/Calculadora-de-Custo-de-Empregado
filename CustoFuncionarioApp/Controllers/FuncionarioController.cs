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
                var custoFuncionario = CalcularCustoFuncionario(funcionario);
                ViewData["CustoFuncionario"] = custoFuncionario;
            }

            return View("Index", funcionario);
        }

        public static decimal CalcularCustoFuncionario(Funcionario funcionario)
        {
            return funcionario.SalarioBase + funcionario.Beneficio - funcionario.Desconto;
        }
    }
}
