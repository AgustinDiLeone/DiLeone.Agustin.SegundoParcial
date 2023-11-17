using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarIgualdadCelulares()
        {
            Celular celularUno = new Celular(10, 300, 10000, "A23", "Samsung", EFactura.A, 18.5, 256, 3);
            Celular celularDos = new Celular(10, 300, 10000, "A23", "Samsung", EFactura.A, 18.5, 256, 3);

            bool rta = celularUno == celularDos;

            Assert.IsTrue(rta);

        }
        [TestMethod]
        public void VerificarIgualdadCelulares_falla()
        {
            Celular celularUno = new Celular(10, 300, 10000, "A23", "Samsung", EFactura.A, 18.5, 256, 3);
            Celular celularDos = new Celular(8, 20, 50000, "M40", "Motorola", EFactura.B, 20.9, 1000, 5);

            bool rta = celularUno == celularDos;

            Assert.IsFalse(rta);
        
        }
    }
}