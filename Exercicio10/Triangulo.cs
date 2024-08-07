﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class Triangulo : Forma
    {
        private double Base { get; set; }
        private double Altura { get; set; }
        public Triangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }
        public override double Area()
        {
            return (0.5 * Base * Altura);
        }
    }
}
