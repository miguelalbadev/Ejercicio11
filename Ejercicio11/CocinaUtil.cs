using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class CocinaUtil{
        private static bool llamado = false;

        public void Calentar(Alimentos alimento1, Alimentos alimento2) {
            llamado = true;
            // TODO
            // throw new Exception("No implementado todavía");
        }

        public static bool IsLlamado() {
            return llamado;
        }
    }
}
