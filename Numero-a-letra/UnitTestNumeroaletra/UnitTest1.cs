using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_a_letra.Controllers;

namespace UnitTestNumeroaletra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumeroLetra()
        {
            //Arrange
            LiteralController LitController = new LiteralController();

            int a = 6;
            string esperado = "SEIS";

            //Act
            string resultado = LitController.LiteralGet(a);
            //Assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
