using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace UnitTestProject11 {
    [TestClass]
    public class CategoriaServiceTest {
        [TestMethod]
        public void TestCategoriaCrear() {

            ICategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
            ICategoriaService sut = new CategoriaService(categoriaRepositorio);

            Categorias categoria1 = new Categorias("postres");
            sut.Aniadir(categoria1);
            Assert.AreEqual(true, sut.Aniadir(categoria1));
        }
    }
}
