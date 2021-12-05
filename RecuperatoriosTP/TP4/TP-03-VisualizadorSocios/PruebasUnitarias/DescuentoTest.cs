using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace PruebasUnitarias
{    /// <summary>
     /// Se realizaron 2 Test Unitario en donde se probó el correcto funcionamiento del método 
     /// BuscarSocio y la extensión DesconstarPorcentaje
     /// </summary>
    [TestClass]
    public class DescuentoTest
    {
        [TestMethod]
        public void ValidarDesceuntoDePorcentaje()
        {
            //Arrange
            double Precio = 1500;
            int CantDescuento = 15;
            double valorFinal = 1275;

            //Act
            double retorno = Precio.DescontarPorcentaje(CantDescuento);

            //Assert
            Assert.AreEqual(valorFinal, retorno);
        }
    }
}
