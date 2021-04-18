using Strategy.CalculoImpostos;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo Strategy Pattern - Calculadora de Impostos
            CalculadoraImpostosStartup.Executar();

            Console.ReadKey();
        }
    }
}
