using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.GerarRotasMaps
{
    public class Navegacao
    {
        public IRotaStrategy rotaStrategy { get; private set; }

        public void setRotaStrategy(IRotaStrategy strategy)
        {
            rotaStrategy = strategy;
        }

        public string GerarRota(string pontoA, string pontoB)
        {
            return rotaStrategy.GerarRota(pontoA, pontoB);
        }
    }
}
