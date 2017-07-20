using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class CategoriaService : ICategoriaService {

        private IList<Categorias> listaCategorias = new List<Categorias>();
        private ICategoriaRepositorio categoriaRepositorio;

        public CategoriaService() {

        }
        public CategoriaService(ICategoriaRepositorio categoriaRepositorio) {
            this.categoriaRepositorio = categoriaRepositorio;
        }

        public bool Aniadir(Categorias categorias) { 
            return categoriaRepositorio.Crear(categorias);
        }

        public List<Categorias> Leer() {
            return categoriaRepositorio.Leer();
        }

        public Categorias LeeCategoria(string nombre) {
            return categoriaRepositorio.LeeCategoria(nombre);
        }

        public bool Update(Categorias categoria, string newName) {
            return categoriaRepositorio.Update(categoria, newName);
        }

        public bool Delete(Categorias categoria) {
            return categoriaRepositorio.Delete(categoria);
        }

    }
}
