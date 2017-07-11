using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class Cocina : ICocina {

        
        public void Calentar(Alimentos alimento1, Alimentos alimento2) {

            CocinaUtil cocinaUtil = new CocinaUtil();

            cocinaUtil.Calentar(alimento1, alimento2);
            alimento1.Calentado = true;
            alimento2.Calentado = true;
        }
    }
}
