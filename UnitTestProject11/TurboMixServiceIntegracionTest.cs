using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class TurboMixServiceIntegracionTest {
        private TurboMixService sut;
        private Alimentos alimento1;
        private Alimentos alimento2;

        [TestInitialize]
            public void init() {
            IBascula basculaService = new BasculaService();
            ICocina cocinaService = new CocinaService();

            sut = new TurboMixService(basculaService, cocinaService);
            alimento1 = new Alimentos();
            alimento1.Nombre = "patata";
            alimento1.peso = 25;

            alimento2 = new Alimentos();
            alimento2.Nombre = "zanahoria";
            alimento2.peso = 35;
        }
   
        [TestMethod]
        public void TestPrepararPlato() {
            

            Receta miReceta = new Receta(alimento1, alimento2, 25, 35);
            Platos resultado = sut.PrepararPlato(miReceta,alimento1,alimento2);
            
            Platos mPlato = new Platos(alimento1, alimento2);
            
            //Assert.IsTrue(mPlato.Equals(resultado));
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
