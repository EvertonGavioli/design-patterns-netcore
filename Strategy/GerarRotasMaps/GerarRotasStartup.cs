using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.GerarRotasMaps
{
    public static class GerarRotasStartup
    {
        public static void Executar()
        {
            IRotaStrategy rotaAutomovel = new RotaAutomovel();
            IRotaStrategy rotaBicicleta = new RotaBicicleta();
            IRotaStrategy rotaCaminhada = new RotaCaminhada();

            var navegacao = new Navegacao();

            // Gerar Rota Automóvel
            navegacao.setRotaStrategy(rotaAutomovel);
            string rotaGerada = navegacao.GerarRota("A", "B");

            Console.WriteLine(rotaGerada);

            // Gerar Rota Bicicleta
            navegacao.setRotaStrategy(rotaBicicleta);
            rotaGerada = navegacao.GerarRota("A", "B");

            Console.WriteLine(rotaGerada);

            // Gerar Rota Caminhada
            navegacao.setRotaStrategy(rotaCaminhada);
            rotaGerada = navegacao.GerarRota("A", "B");

            Console.WriteLine(rotaGerada);
        }
    }
}
