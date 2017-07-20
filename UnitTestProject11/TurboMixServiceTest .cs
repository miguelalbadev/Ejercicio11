using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using Moq;

namespace UnitTestProject11 {
    [TestClass]
    public class TurboMixServiceTest {
        
        [TestMethod]
        public void TestPrepararPlato() {
            var mockBasculaService = new Mock<IBascula>();
            var mockCocinaService = new Mock<ICocina>();

            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimentos>()))
                .Returns((Alimentos p)=>p.peso);
            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimentos>()))
                .Returns((Alimentos p) => p.peso);


            mockCocinaService.Setup(cocina => cocina.Calentar(It.IsAny<Alimentos>(), It.IsAny<Alimentos>()))
                .Callback(
                (Alimentos p1, Alimentos p2)
                => {
                    p1.Calentado = true;
                    p2.Calentado = true;
                }
                );
            
            IBascula basculaService = mockBasculaService.Object;
            ICocina cocinaService = mockCocinaService.Object;

            TurboMixService sut = new TurboMixService(basculaService, cocinaService);
            Alimentos alimento1 = new Alimentos();
            alimento1.Nombre = "patata";
            alimento1.peso = 25;

            Alimentos alimento2 = new Alimentos();
            alimento2.Nombre = "zanahoria";
            alimento2.peso = 35;


            Receta miReceta = new Receta(alimento1, alimento2, 25, 35);
            Platos resultado = sut.PrepararPlato(miReceta,alimento1,alimento2);

            mockBasculaService.Verify(bascula => bascula.Pesar(It.IsAny<Alimentos>()), Times.AtLeast(2));
            mockCocinaService.Verify(cocina => cocina.Calentar(It.IsAny<Alimentos>(), It.IsAny<Alimentos>()),
            Times.Once);

            Platos mPlato = new Platos(alimento1, alimento2);
                        
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
