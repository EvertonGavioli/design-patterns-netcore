using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.CalculoImpostos
{
    // Context - Faz a orquestração, chama o método de execução,
    // O contexto não sabe qual o tipo de estratégia ele esta 
    // trabalhando ou como a estratégia é executada.
    public static class CalculadoraImpostos
    {
        public static decimal CalcularImposto(Pedido pedido, IImposto imposto)
        {
            return imposto.Calcular(pedido);
        }
    }
}
