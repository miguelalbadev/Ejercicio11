using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class CocinaServiceTest {
        [TestMethod]
        public void TestCocinar() {
            ICocina sut = new CocinaService();

            Alimentos alimento1 = new Alimentos();
            Alimentos alimento2 = new Alimentos();

            sut.Calentar(alimento1, alimento2);

            Assert.IsTrue(alimento1.Calentado);
            Assert.IsTrue(alimento2.Calentado);
        }
    }
}
