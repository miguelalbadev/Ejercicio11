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
               
        public Platos PrepararPlato(Receta miReceta, Alimentos alimento1, Alimentos alimento2) {
            
            int peso1 = Bascula.Pesar(miReceta.alimento1);
            int peso2 = Bascula.Pesar(miReceta.alimento2);
            if (!alimento1.Calentado && !alimento2.Calentado) {
                if(peso1 >= miReceta.pesoAlimento1 && peso2 >= miReceta.pesoAlimento2) {
                    alimento1.peso = miReceta.pesoAlimento1;
                    alimento2.peso = miReceta.pesoAlimento2;

                    Cocina.Calentar(miReceta.alimento1, miReceta.alimento2);
                    return new Platos(miReceta.alimento1, miReceta.alimento2);
                }
            }
            
            return null;
        }

        public Platos PrepararPlatoConReceta() {
            return null;
        }
    }
}
