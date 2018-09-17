﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalRampa : Señal
    {
        

        public SeñalRampa()
        {
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }


        override public double evaluar(double tiempo)
        {
            double resultado;
            
            if(tiempo >= 0)
            {
                resultado = tiempo;
            }else
            {
                resultado = 0;
            }

            return resultado;
        }
    }
}
