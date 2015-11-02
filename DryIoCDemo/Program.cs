using DryIoc;
using System;
using System.Collections.Generic;

namespace DryIoCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            container.Register<ICalculo, Soma>();
            container.Register<ICalculo, Subtracao>();
            container.Register<Calculadora>(Reuse.Singleton);

            Calculadora calculadora = container.Resolve<Calculadora>();
            calculadora.EfetuarCalculos(500, 200);

            IEnumerable<ICalculo> calculos = container.Resolve<IEnumerable<ICalculo>>();
            foreach (var calculo in calculos)
            {
                var result = calculo.Calcular(100, 50);
                Console.WriteLine($"Resultado: {result}");
            }

            Console.Read();
        }
    }
}
