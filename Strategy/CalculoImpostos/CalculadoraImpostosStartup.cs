using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.CalculoImpostos
{
    // Cliente - Criar um objeto de uma estratégia em especifico e passa para o contexto.
    public static class CalculadoraImpostosStartup
    {
        public static void Executar()
        {
            IImposto icms = new ICMS();
            IImposto iss = new ISS();

            Pedido pedido = new Pedido(1000.0m);

            var valorICMS = CalculadoraImpostos.CalcularImposto(pedido, icms);
            var valorISS = CalculadoraImpostos.CalcularImposto(pedido, iss);

            Console.WriteLine($"Valor do ICMS: {valorICMS}");
            Console.WriteLine($"Valor do ISS: {valorISS}");
        }
    }
}
