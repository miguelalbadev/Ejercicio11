using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class Platos {
        Alimentos alimento1 {
            get;
            set;
        }
        Alimentos alimento2 {
            get;
            set;
        }
        public Platos(Alimentos alimento1, Alimentos alimento2) {
            this.alimento1 = alimento1;
            this.alimento2 = alimento2;
        }
    }
}
