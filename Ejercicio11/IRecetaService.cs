﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11 {
    public interface IRecetaService {

        void Aniadir(Receta receta);
        List<Receta> Leer();

        Receta LeeReceta(string nombre);

        void Update(Receta receta);

        void Delete(Receta receta);

    }
}
