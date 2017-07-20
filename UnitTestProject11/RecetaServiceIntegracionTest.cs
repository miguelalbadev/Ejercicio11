using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using Microsoft.Practices.Unity;

namespace UnitTestProject11 {
    
    /// <summary>
    /// Descripción resumida de RecetaServiceIntegracionTest
    /// </summary>
    [TestClass]
    public class RecetaServiceIntegracionTest {

        IUnityContainer container;
        IRecetaRepositorio recetaRepositorio;
        IRecetaService sut;

        [TestInitialize]
        public void Initialize() {

            container = new UnityContainer();
            container.RegisterType<IRecetaRepositorio, RecetaRepositorio>();
            container.RegisterType<IRecetaService, RecetaService>();
            
        }


        [TestMethod]
        public void TestGuardarReceta() {
                       
            recetaRepositorio = container.Resolve<IRecetaRepositorio>();
            sut = container.Resolve<IRecetaService>();

            Receta receta = new Receta();
            sut.Aniadir(receta);
            
        }
        [TestMethod]
        public void TestLeer() {
            recetaRepositorio = container.Resolve<IRecetaRepositorio>();
            sut = container.Resolve<IRecetaService>();

            sut.Leer();
        }

        [TestMethod]
        public void TestLeerReceta() {
            Receta receta = new Receta();
            recetaRepositorio = container.Resolve<IRecetaRepositorio>();
            sut = container.Resolve<IRecetaService>();

            sut.LeeReceta(receta.nombre);
        }

        [TestMethod]
        public void TestUpdateReceta() {
            Receta receta = new Receta();
            recetaRepositorio = container.Resolve<IRecetaRepositorio>();
            sut = container.Resolve<IRecetaService>();

            sut.Update(receta);
        }

        [TestMethod]
        public void TestDeleteReceta() {
            Receta receta = new Receta();
            recetaRepositorio = container.Resolve<IRecetaRepositorio>();
            sut = container.Resolve<IRecetaService>();

            sut.Delete(receta);
        }
    }
}
