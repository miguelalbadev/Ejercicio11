using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class ProcesoCocinar : ICocinar {

        public Platos Cocinar(Alimentos alimento1, Alimentos alimento2) {
            CocinarService cocinar = new CocinarService();
            return cocinar.Cocina(alimento1, alimento2);
        }
    }
}
