using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class TurboMixTest {
        [TestMethod]
        public void TestTurboMix() {

            TurboMix sut = new TurboMix();
            sut.Bascula = new BasculaPrueba();
            sut.Cocina = new CocinaPrueba();
            Alimentos alimento1 = new Alimentos();
            Alimentos alimento2 = new Alimentos();
            sut.ProcesoCompleto(alimento1, alimento2);
        }

        public class BasculaPrueba : IBascula {
            public int Pesar(Alimentos alimento1) {
                return alimento1.peso;
            }

        }

        public class CocinaPrueba : ICocina {
            public void Calentar(Alimentos alimento1, Alimentos alimento2) {
                
            }

        }
    }
}
