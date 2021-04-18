using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.CalculoImpostos
{
    public class Pedido
    {
        public Pedido(decimal valorTotal)
        {
            ValorTotal = valorTotal;
        }

        public decimal ValorTotal { get; set; }
    }
}
