using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace PruebasUnitarias
{    /// <summary>
     /// Se realizaron 2 Test Unitario en donde se prob� el correcto funcionamiento del m�todo 
     /// BuscarSocio y la extensi�n DesconstarPorcentaje
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
