using System.Collections.Generic;

namespace Ejercicio11 {
    public interface ICategoriaRepositorio {

        bool Crear(Categorias categoria);
        bool Delete(Categorias categoria);
        Categorias LeeCategoria(string nombreCategoria);
        List<Categorias> Leer();
        bool Update(Categorias categoria, string newName);
    }
}