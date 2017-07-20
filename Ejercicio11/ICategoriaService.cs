using System.Collections.Generic;

namespace Ejercicio11 {
    public interface ICategoriaService {
        bool Aniadir(Categorias categorias);
        bool Delete(Categorias categoria);
        Categorias LeeCategoria(string nombre);
        List<Categorias> Leer();
        bool Update(Categorias categoria, string newName);
    }
}