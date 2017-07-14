using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class RecetaService : IRecetaService {

        private IRecetaRepositorio recetaRepositorio;

        public RecetaService() {

        }
        public RecetaService(IRecetaRepositorio recetaService) {
            this.recetaRepositorio = recetaService;
        }

        public void Aniadir(Receta receta) {
            recetaRepositorio.Crear(receta);
        }
    }
}
