using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1__.NET.Models
{
    public class Calculadora
    {
        public void RaizQuadrada(double x){



            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é: {raiz}");
        }
    }
}