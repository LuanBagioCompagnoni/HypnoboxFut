using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnoboxFut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> timeA = new List<int>();
            List<int> timeB = new List<int>();

            Console.WriteLine("Por favor, informe a quantidade de gols que o time marcou em cada partida.\n");
            Console.WriteLine("Siga o padrão gols,gols,gols. Cada virgula separa o jogo. Ex:\njogo1,jogo2,jogo2\n");
            Console.WriteLine("Primeiro, informe os gols do time A:\n");
            string golsTimeA = Console.ReadLine();
            List<string> jogosTimeA = golsTimeA.Split(',').ToList();
            foreach (string jogo in jogosTimeA)
            {
                timeA.Add(int.Parse(jogo));
            }
            Console.WriteLine("Agora, informe os gols do time B:\n\n");
            string golsTimeB = Console.ReadLine();
            List<string> jogosTimeB = golsTimeB.Split(',').ToList();
            foreach (string jogo in jogosTimeB)
            {
                timeB.Add(int.Parse(jogo));
            }
            int numJogo = 1;
            foreach (var golsB in timeB)
            {
                int resultadoMaior = 0;
                int resultadoIgual = 0;
                foreach (var golsA in timeA)
                {
                    if (golsB > golsA)
                        resultadoMaior++;
                    else if(golsB == golsA)
                        resultadoIgual++;
                }
                Console.WriteLine($"Jogo {numJogo}. Time B marcou mais gols em {resultadoMaior} jogos, e empatou em {resultadoIgual} jogos!\n");
                numJogo++;
            }
            Console.ReadLine();
        }
    }
}
