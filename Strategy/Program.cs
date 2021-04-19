using Strategy.CalculoImpostos;
using Strategy.GerarRotasMaps;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Exemplo Strategy Pattern - Calculadora de Impostos
            // CalculadoraImpostosStartup.Executar();

            // Exemplo Strategy Pattern - Gerar rotas para mapa
            GerarRotasStartup.Executar();

            Console.ReadKey();
        }
    }
}
