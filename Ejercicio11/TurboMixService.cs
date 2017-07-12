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
               
        public Platos ProcesoCompleto(RecetaService miReceta) {
            
            int peso1 = Bascula.Pesar(miReceta.alimento1);
            int peso2 = Bascula.Pesar(miReceta.alimento2);
            if (peso1 == miReceta.pesoAlimento1 && peso2==miReceta.pesoAlimento2) {
                if (miReceta.alimento1.Calentado == false && miReceta.alimento2.Calentado == false) {
                    Cocina.Calentar(miReceta.alimento1, miReceta.alimento2);
                    return new Platos(miReceta.alimento1, miReceta.alimento2);
                }
            }

            return null;
        }
    }
}
