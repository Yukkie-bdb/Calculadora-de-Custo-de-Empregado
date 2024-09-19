using CustoFuncionarioApp.Models;

namespace TesteCalculoCustoFunc
{
    public class UnitTest1
    {
        [Fact]
        public void TestarCalculo()
        {
            var f = new Funcionario()
            {
                SalarioBase = 1000,
                Desconto = 150,
                Beneficio = 10
            };

            Assert.Equal(860, CustoFuncionarioApp.Controllers.FuncionarioController.CalcularCustoFuncionario(f));
        }
    }
}