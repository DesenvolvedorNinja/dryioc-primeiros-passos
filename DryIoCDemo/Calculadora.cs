using System;
using System.Collections.Generic;

namespace DryIoCDemo
{
    public class Calculadora
    {
        IEnumerable<ICalculo> Calculos { get; set; }

        public Calculadora(IEnumerable<ICalculo> calculos)
        {
            this.Calculos = calculos;
        }

        public void EfetuarCalculos(double a, double b)
        {
            foreach (var calculo in Calculos)
            {
                var result = calculo.Calcular(a, b);
                Console.WriteLine($"Resultado: {result}");
            }
        }
    }
}
