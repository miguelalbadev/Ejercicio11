﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public class Receta {
        public string nombre { get; set; }
        public Alimentos alimento1 { get; set; }
        public Alimentos alimento2 { get; set; }
        public Categorias categoria { get; set; }

        public int pesoAlimento1 { get; set; }
        public int pesoAlimento2 { get; set; }

        public Receta() {

        }
        public Receta (Alimentos alimento1, Alimentos alimento2, int pesoAlimento1, int pesoAlimento2) {
            this.alimento1 = alimento1;
            this.alimento2 = alimento2;
            this.pesoAlimento1 = pesoAlimento1;
            this.pesoAlimento2 = pesoAlimento2;
        }
        
    }
}
