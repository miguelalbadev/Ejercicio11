using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class RecetaService : IRecetaService {

        private IRecetaRepositorio recetaRepositorio;
        private IList<Receta> listaRecetas = new List<Receta>();
        public RecetaService() {

        }
        public RecetaService(IRecetaRepositorio recetaService) {
            this.recetaRepositorio = recetaService;
        }

        public void Aniadir(Receta receta) {
            recetaRepositorio.Crear(receta);
        }

        public List<Receta> Leer() {
            return recetaRepositorio.Leer();
        }

        public Receta LeeReceta(string nombre) {
            return recetaRepositorio.LeeReceta(nombre);
        }

        public void Update(Receta receta) {
            recetaRepositorio.Update(receta);
        }

        public void Delete(Receta receta) {
            recetaRepositorio.Delete(receta);
        }


    }
}
