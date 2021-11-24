using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoCalculadora;

namespace ProjetoCalculadoraTeste
{
    [TestClass]
    public class CalculadoraSimplesTeste
    {
        [TestMethod]
        public void DeveAdicionarDoisNumeros()
        {
            var calculadoraSimples = new CalculadoraSimples();
            var resultadoEsperado = calculadoraSimples.Adicionar(5, 2);

            //ASSERT - Resultado Esperado
            Assert.AreEqual(7, resultadoEsperado);
        }

        [TestMethod]
        public void DeveMultiplicarDoisNumeros()
        {
            var calculadoraSimples = new CalculadoraSimples();
            var resultadoEsperado = calculadoraSimples.Multiplicar(8, 2);

            Assert.AreEqual(16, resultadoEsperado);
        }

        [TestMethod]
        public void DeveSubtrairDoisNumeros()
        {
            var calculadoraSimples = new CalculadoraSimples();
            var resultadoEsperado = calculadoraSimples.Diminuir(10, 5);

            Assert.AreEqual(5, resultadoEsperado);
        }

        [TestMethod]
        public void DeveDividirDoisNumeros()
        {
            var calculadoraSimples = new CalculadoraSimples();
            var resultadoEsperado = calculadoraSimples.Dividir(21, 3);

            Assert.AreEqual(7, resultadoEsperado);
        }
    }
}
