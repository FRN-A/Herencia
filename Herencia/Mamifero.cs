﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Mamifero : Animal
    {

        public override string desplazar()
        {
            return Nombre + " Esta caminando";
        }
    }
}
