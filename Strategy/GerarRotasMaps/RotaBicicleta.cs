using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.GerarRotasMaps
{
    public class RotaBicicleta : IRotaStrategy
    {
        public string GerarRota(string pontoA, string pontoB)
        {
            return $"Rota Bicicleta: {pontoA} - {pontoB}";
        }
    }
}
