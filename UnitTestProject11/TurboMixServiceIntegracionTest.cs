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
            alimento1.Nombre = "patata";
            alimento1.peso = 25;

            Alimentos alimento2 = new Alimentos();
            alimento2.Nombre = "zanahoria";
            alimento2.peso = 35;

            Receta miReceta = new Receta(alimento1, alimento2, 25, 35);
            Platos resultado = sut.ProcesoCompleto(miReceta);
            
            Platos mPlato = new Platos(alimento1, alimento2);
            
            //Assert.IsTrue(mPlato.Equals(resultado));
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
