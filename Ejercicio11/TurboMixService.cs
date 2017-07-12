using Ejercicio11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class TurboMixService {
                
        public IBascula Bascula {get;set;}
        public ICocina Cocina {get;set;}

        public TurboMixService(IBascula Bascula, ICocina Cocina) {
            this.Bascula = Bascula;
            this.Cocina = Cocina;
        }

        public Platos ProcesoCompleto(Alimentos alimento1, Alimentos alimento2) {
            
            int peso1 = Bascula.Pesar(alimento1);
            int peso2 = Bascula.Pesar(alimento2);
            
            Cocina.Calentar(alimento1, alimento2);
            return new Platos(alimento1, alimento1);
        }
    }
}
