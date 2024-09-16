using System.Security.Cryptography.X509Certificates;

namespace MathLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularFatorial()
        {
            int valor = 0;
            long Esperado = 1;


            long resultado = MathUtils.CalcularFatorial(valor);

            Assert.AreEqual(Esperado, resultado);
        }

        public void CalcularFatorial_valorNegativo_LancaArgumentException()
        {
            int Valor = -1;

            MathUtils.CalcularFatorial(Valor);

        }
    }
}