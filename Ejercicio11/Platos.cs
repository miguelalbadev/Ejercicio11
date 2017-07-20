using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class Platos {
        Alimentos alimento1 {get;set;}
        Alimentos alimento2 {get;set;}
        public String Nombre;

        public Platos(Alimentos alimento1, Alimentos alimento2) {
            this.alimento1 = alimento1;
            this.alimento2 = alimento2;
            Nombre = "" + alimento1 + alimento2;
        }

        public override bool Equals(object obj) {
            Platos a = (Platos)obj;
            if (obj == null) {
                return false;
            }
            else if (!this.GetType().Equals(obj.GetType())) {
                return false;
            }
            else if (this.alimento1 == null && a.alimento1 != null) {
                return false;
            }
            else if(this.alimento1 != null && !this.alimento1.Equals(a.alimento1)) {
                return false;
            }
            else if (this.alimento2 == null && a.alimento2 != null) {
                return false;
            }
            else if (this.alimento2 != null && !this.alimento2.Equals(a.alimento2)) {
                return false;
            }
            return true;
            
        }

        public override string ToString() {
            return this.alimento1+" "+this.alimento2;
        }
    }
}
