using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class ProcesoCocinarTest {
        [TestMethod]
        public void TestCocinar() {
            Alimentos alimento1 = new Alimentos();
            Alimentos alimento2 = new Alimentos();
            Platos plato;
            ProcesoCocinar cocina = new ProcesoCocinar();
            plato = cocina.Cocinar(alimento1, alimento2);
            Assert.AreEqual(plato, plato);
        }
    }
}
