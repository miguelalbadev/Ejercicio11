using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class ProcesoPesar : IPesar {

        public int Pesar(Alimentos alimento1, Alimentos alimento2) {
            return alimento1.peso+alimento2.peso;
        }
    }
}
