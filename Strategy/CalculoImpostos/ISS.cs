using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.CalculoImpostos
{
    // Classe Concreta - Implementa as regras de negócio específicas para cálculo ISS
    public class ISS : IImposto
    { 
        public decimal Calcular(Pedido pedido)
        {
            return pedido.ValorTotal * 0.06m;
        }
    }
}
