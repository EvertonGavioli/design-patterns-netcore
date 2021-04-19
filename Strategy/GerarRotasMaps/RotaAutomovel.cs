using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.GerarRotasMaps
{
    public class RotaAutomovel : IRotaStrategy
    {
        public string GerarRota(string pontoA, string pontoB)
        {
            return $"Rota Automóvel: {pontoA} - {pontoB}";
        }
    }
}
