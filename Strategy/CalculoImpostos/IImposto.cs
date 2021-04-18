using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.CalculoImpostos
{
    // Interface - Comum a todas as estratégias concretas.
    // Declara o método a qual o Context usa para 
    // executar uma estratégia.
    public interface IImposto
    {
        public decimal Calcular(Pedido pedido);
    }
}
