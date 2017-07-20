using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class ProcesoPesarTest {
        [TestMethod]
        public void TestPesar() {
            
            Alimentos alimento1 = new Alimentos();
            alimento1.peso = 15;
            Alimentos alimento2 = new Alimentos();
            alimento2.peso = 30;
            IBascula procesoPesar = new BasculaService();
            //int resultado = procesoPesar.Pesar(alimento1, alimento2);
            //Assert.AreEqual(resultado, 45);
        }
    }
}
