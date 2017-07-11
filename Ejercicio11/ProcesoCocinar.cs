using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class ProcesoCocinar : ICocinar {

        public Platos Cocinar(Alimentos alimento1, Alimentos alimento2) {
            Platos plato = new Platos(alimento1, alimento2);
            return plato;
        }
    }
}
