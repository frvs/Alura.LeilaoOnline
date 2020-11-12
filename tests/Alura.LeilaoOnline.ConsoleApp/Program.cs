using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var leilao = new Leilao("Van Gogh");
            var user1 = new Interessada("Lucas", leilao);
            var user2 = new Interessada("Nathalia", leilao);

            leilao.RecebeLance(user1, 800);
            leilao.RecebeLance(user2, 900);
            leilao.RecebeLance(user1, 1000);
            leilao.RecebeLance(user2, 990);
            

            leilao.TerminaPregao();

            Console.WriteLine(leilao.Ganhador.Valor);
        }
    }
}
