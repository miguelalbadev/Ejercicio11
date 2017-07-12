using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Alimentos{
        public int peso {get;set;}
        public bool Calentado {get;set;}
        public string Nombre { get; set; }

        public Alimentos() {
            this.peso = 0;
            this.Calentado = false;
        }

        public Alimentos(int peso, bool calentado) {
            this.peso = peso;
            this.Calentado = calentado;
        }

        public override bool Equals(object obj) {
            Alimentos a = (Alimentos)obj;
            if (obj == null) {
                return false;
            }
            else if (!this.GetType().Equals(obj.GetType())) {
                return false;
            }
            else if (a.Nombre == null) {
                if (this.Nombre == null) {
                    return true;
                }
                else {
                    if (!this.Nombre.Equals(a.Nombre)) {
                        return false;
                    }
                }
               
            }
            return this.Nombre.Equals(a.Nombre);
        }

        public override string ToString() {
            return this.Nombre;
        }

    }
}
