using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.GerarRotasMaps
{
    public class RotaCaminhada : IRotaStrategy
    {
        public string GerarRota(string pontoA, string pontoB)
        {
            return $"Rota Caminhada: {pontoA} - {pontoB}";
        }
    }
}
