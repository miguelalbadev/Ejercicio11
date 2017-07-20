using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class CategoriaRepositorio : ICategoriaRepositorio {

        private IList<Categorias> listaCategorias = new List<Categorias>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns>true if categoria has added succesfull. False in other cases</returns>
        public bool Crear(Categorias categoria) {
            bool existe = false;
            bool almacenado = false;
            if (listaCategorias.Count == 0) {
                listaCategorias.Add(categoria);
                almacenado = true;
            }
            foreach(var cat in listaCategorias) {
                if (!cat.nombreCategoria.Equals(categoria.nombreCategoria)) {
                    existe = false;
                }
                else if (cat.nombreCategoria.Equals(categoria.nombreCategoria)) {
                    existe = true;
                    break;
                }
            }
            if (!existe) {
                listaCategorias.Add(categoria);
                almacenado = true;
            }
            return almacenado;
            
        }

        public List<Categorias> Leer() {
            return (List<Categorias>)listaCategorias;
        }

        public Categorias LeeCategoria(string nombreCategoria) {
            Categorias categoria = null;
            
            foreach (var cat in listaCategorias) {
                if (cat.nombreCategoria.Equals(nombreCategoria)) {
                    categoria = cat;
                    break;
                }
            }
            return categoria;
        }

        public bool Update(Categorias categoria, string newName) {
            bool actualizado = false;
            foreach (var cat in listaCategorias) {
                if (cat.nombreCategoria.Equals(categoria.nombreCategoria)) {
                    cat.nombreCategoria = newName;
                    actualizado = true;
                    break;
                }
            }
            return actualizado;
        }

        public bool Delete(Categorias categoria) {
            bool eliminado = false;
            foreach (var cat in listaCategorias) {
                if (cat.nombreCategoria.Equals(categoria.nombreCategoria)) {
                    listaCategorias.Remove(cat);
                    eliminado = true;
                    break;
                }
            }
            return eliminado;
        }
    }
}
