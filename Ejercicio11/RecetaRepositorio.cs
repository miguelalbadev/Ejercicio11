using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class RecetaRepositorio:IRecetaRepositorio {

        private IList<Receta> listaRecetas = new List<Receta>();

        public void Crear(Receta receta) {
            listaRecetas.Add(receta);
        }

        public List<Receta> Leer() {
            return (List<Receta>)listaRecetas;
        }

        public Receta LeeReceta(string nombreReceta) {
            Receta receta = new Receta();
            return receta;
        }

        public void Update(Receta receta) {

        }

        public void Delete(Receta receta) {

        }

        
    }
}
