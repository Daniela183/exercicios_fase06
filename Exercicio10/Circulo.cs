﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class Circulo : Forma
    {
        private double Raio { get; set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double Area()
        {
            return (Math.PI * Raio * Raio);
        }
    }

}