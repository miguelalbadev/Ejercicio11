using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public interface IRecetaRepositorio {

        void Crear(Receta receta);
        List<Receta> Leer();
        void Update(Receta receta);
        void Delete(Receta receta);
        Receta LeeReceta(string nombreReceta);
    }
}
