using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class TurboMixServiceIntegracionTest {
        [TestMethod]
        public void TestPrepararPlato() {
            IBascula basculaService = new BasculaService();
            ICocina cocinaService = new CocinaService();

            TurboMixService sut = new TurboMixService(basculaService, cocinaService);
            Alimentos alimento1 = new Alimentos();
            
            alimento1.peso = 15;
            Alimentos alimento2 = new Alimentos();
            alimento2.peso = 30;
            
            Platos resultado = sut.ProcesoCompleto(alimento1, alimento2);
            
            Platos mPlato = new Platos(alimento1, alimento2);
            
            //Assert.IsTrue(mPlato.Equals(resultado));
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
