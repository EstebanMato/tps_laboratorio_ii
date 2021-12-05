using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace PruebasUnitarias
{
    /// <summary>
    /// Se realizaron 2 Test Unitario en donde se probó el correcto funcionamiento del método 
    /// BuscarSocio y la extensión DesconstarPorcentaje
    /// </summary>
    [TestClass]
    public class BuscarSocioTest
    {
        [TestMethod]
        public void ValidarBusquedaSocios()
        {
            //Arrange
            Simple socio = new Simple("Esteban", "Mato", "37995842", EProvincia.CapitalFederal, "M", 27 , 912, 500, DateTime.Now, true);
            Club club = new Club("River Plate");
            club += socio;

            //Act
            Socio socio2= club.BuscarSocio(socio.NumeroSocio);

            //Assert
            Assert.AreEqual(socio.Nombre, socio2.Nombre);
        }
    }
}
