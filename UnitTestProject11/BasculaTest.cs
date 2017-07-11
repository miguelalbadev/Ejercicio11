using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class BasculaTest {
        [TestMethod]
        public void TestPesar() {
            Bascula sut = new Bascula();
            Alimentos alimento1 = new Alimentos();
            alimento1.peso = 35;
            int peso = sut.Pesar(alimento1);
            Assert.AreEqual(35, peso);
        }
    }
}
