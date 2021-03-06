﻿using Ejercicio11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class TurboMixService {
                
        public IBascula bascula {get;set;}
        public ICocina cocina {get;set;}

        

        public TurboMixService(IBascula Bascula, ICocina Cocina) {
            this.bascula = Bascula;
            this.cocina = Cocina;
            
        }
               
        public Platos PrepararPlato(Receta miReceta, Alimentos alimento1, Alimentos alimento2) {
            /*Platos platoReturn = null;
            int peso1 = bascula.Pesar(miReceta.alimento1);
            int peso2 = bascula.Pesar(miReceta.alimento2);
            if (!alimento1.Calentado && !alimento2.Calentado) {
                if(peso1 >= miReceta.pesoAlimento1 && peso2 >= miReceta.pesoAlimento2) {
                    alimento1.peso = miReceta.pesoAlimento1;
                    alimento2.peso = miReceta.pesoAlimento2;

                    cocina.Calentar(miReceta.alimento1, miReceta.alimento2);
                    platoReturn = new Platos(miReceta.alimento1, miReceta.alimento2);
                    return platoReturn;
                }
            }*/
            int peso1 = bascula.Pesar(alimento1);
            int peso2 = bascula.Pesar(alimento2);
            cocina.Calentar(alimento1, alimento2);
            return new Platos(alimento1, alimento2);
            
            
        }
        public void aniadirReceta(Receta receta) {
            RecetaService recetaService = new RecetaService();
            recetaService.Aniadir(receta);
        }       

        /*public Platos PrepararPlatoConReceta() {
            return null;
        }*/
    }
}
