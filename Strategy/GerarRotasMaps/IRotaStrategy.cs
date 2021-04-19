using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.GerarRotasMaps
{
    public interface IRotaStrategy
    {
        public string GerarRota(string pontoA, string pontoB);
    }
}
