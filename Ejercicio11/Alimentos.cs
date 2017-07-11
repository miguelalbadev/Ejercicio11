using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Alimentos{
        public int peso {
            get;
            set;
        }

        public bool Calentado {
            get;
            set;
        }
        public Alimentos() {
            this.peso = 0;
            this.Calentado = false;
        }

        public Alimentos(int peso, bool calentado) {
            this.peso = peso;
            this.Calentado = calentado;
        }

    }
}
