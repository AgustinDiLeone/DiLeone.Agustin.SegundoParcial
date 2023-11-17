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
        [TestMethod]
        public void VerificarNotebooksNulas()
        {
            Notebook notebookUna = null;
            Notebook notebookDos = null;

            bool rta = notebookUna == notebookDos;

            Assert.IsTrue(rta);

        }
        [TestMethod]
        public void Cliente()
        {
            Cliente cliente = new Cliente(22148528585, "Sura",ETipos.ResponsableInscripto,"Lanus");

            List<DispositivoElectronico> celulares = cliente.Dispositivos;

            Assert.IsNotNull(celulares);
        }
        [TestMethod]
        public void ClienteDefault()
        {
            Cliente cliente = new Cliente();

            List<DispositivoElectronico> celulares = cliente.Dispositivos;

            Assert.IsNotNull(celulares);
        }
        [TestMethod]
        public void AgregarTelevisoresFalla()
        {
            //Arrange
            Cliente cliente = new Cliente(16913167521, "Agustin", ETipos.ResponsableInscripto, "Buenos Aires");
            Televisor televisorUno = new Televisor(20, 400, 100000, "UTP350", "LG", EFactura.C, 1080, 100.5);

            cliente += televisorUno;
            cliente += televisorUno;

            //Deberia solo agregar el primero, porque son el mismo dispositivo. 
            //Por lo que deberia haber un unico dispositivo
            int dispositivosAgregados = cliente.Dispositivos.Count;
            int dispositivosEsperados = 1;
            
            Assert.AreEqual(dispositivosEsperados, dispositivosAgregados);
        }
    }
}