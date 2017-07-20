using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ejercicio11;

namespace UnitTestProject11 {
    /// <summary>
    /// Descripción resumida de RecetaServiceIntegracionTest
    /// </summary>
    [TestClass]
    public class RecetaServiceTest {
        

        [TestMethod]
        public void TestGuardarReceta() {
            var mockRecetaRepositorio = new Mock<IRecetaRepositorio>();
            Receta receta = new Receta();

            IRecetaService sut = new RecetaService(mockRecetaRepositorio.Object);
            sut.Aniadir(receta);

            mockRecetaRepositorio.Verify(recetaRepository => recetaRepository.Crear(It.IsAny<Receta>()), Times.Once);
            
        }

        [TestMethod]
        public void TestLeer() {
            var mockRecetaRepositorio = new Mock<IRecetaRepositorio>();
            Receta receta = new Receta();

            IRecetaService sut = new RecetaService(mockRecetaRepositorio.Object);
            sut.Aniadir(receta);

            mockRecetaRepositorio.Verify(recetaRepository => recetaRepository.Crear(It.IsAny<Receta>()), Times.Once);

        }
    }
}
