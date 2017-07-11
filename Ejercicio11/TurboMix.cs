using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class TurboMix {

        public IPesar procesoPesar {
            get;
            set;
        }
        public ICocinar procesoCocinar {
            get;
            set;
        }

        public void ProcesoCompleto(Alimentos alimento1, Alimentos alimento2) {
            int peso = procesoPesar.Pesar(alimento1,alimento2);
            Platos plato = procesoCocinar.Cocinar(alimento1, alimento2);
        }
    }
}
