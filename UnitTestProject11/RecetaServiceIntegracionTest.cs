using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    /// <summary>
    /// Descripción resumida de RecetaServiceIntegracionTest
    /// </summary>
    [TestClass]
    public class RecetaServiceIntegracionTest {
        

        [TestMethod]
        public void TestGuardarReceta() {
            Receta receta = new Receta();
            IRecetaRepositorio recetaRepositorio = new RecetaRepositorio();
            IRecetaService sut = new RecetaService(recetaRepositorio);

            sut.Aniadir(receta);
            
        }
        [TestMethod]
        public void TestLeer() {
            IRecetaRepositorio recetaRepositorio = new RecetaRepositorio();
            IRecetaService sut = new RecetaService(recetaRepositorio);

            sut.Leer();
        }

        [TestMethod]
        public void TestLeerReceta() {
            Receta receta = new Receta();
            IRecetaRepositorio recetaRepositorio = new RecetaRepositorio();
            IRecetaService sut = new RecetaService(recetaRepositorio);

            sut.LeeReceta(receta.nombre);
        }

        [TestMethod]
        public void TestUpdateReceta() {
            Receta receta = new Receta();
            IRecetaRepositorio recetaRepositorio = new RecetaRepositorio();
            IRecetaService sut = new RecetaService(recetaRepositorio);

            sut.Update(receta);
        }

        [TestMethod]
        public void TestDeleteReceta() {
            Receta receta = new Receta();
            IRecetaRepositorio recetaRepositorio = new RecetaRepositorio();
            IRecetaService sut = new RecetaService(recetaRepositorio);

            sut.Delete(receta);
        }
    }
}
