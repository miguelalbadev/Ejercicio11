using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class BasculaService : IBascula {

        public int Pesar(Alimentos alimento1) {
            return alimento1.peso;
        }
    }
}
