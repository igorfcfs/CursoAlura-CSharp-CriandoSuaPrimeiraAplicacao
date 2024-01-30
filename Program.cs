using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirOpcoesMenu();
        }

        //static List<string> bandas = new List<string>();
        static Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

        static void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas Vindas ao Screen Sound");
        }

        static void ExibirOpcoesMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda.");
            Console.WriteLine("Digite 2 para mostrar todas as bandas.");
            Console.WriteLine("Digite 3 para avaliar uma banda.");
            Console.WriteLine("Digite 4 para exibir a média de uma banda.");
            Console.WriteLine("Digite -1 para sair.");

            Console.Write("\nDigite sua opção: ");
            string opcaoEscolhida = Console.ReadLine();

            switch (int.Parse(opcaoEscolhida))
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    ExibirBandas();
                    break;
                case 3:
                    AvaliarBandas();
                    break;
                case 4:
                    ExibirMediaBandas();
                    break;
                case -1:
                    Console.WriteLine("\nObrigado :)");
                    break;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }
        }

        private static void ExibirMediaBandas()
        {
            Console.Clear();
            Console.WriteLine(@"
▒█▀▄▀█ █▀▀ █▀▀▄ ░▀░ █▀▀█ 　 █▀▀▄ █▀▀█ 　 ▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ 
▒█▒█▒█ █▀▀ █░░█ ▀█▀ █▄▄█ 　 █░░█ █▄▄█ 　 ▒█▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ 
▒█░░▒█ ▀▀▀ ▀▀▀░ ▀▀▀ ▀░░▀ 　 ▀▀▀░ ▀░░▀ 　 ▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀
");
            Console.Write("Digite a banda que quer avaliar: ");
            string banda = Console.ReadLine();
            if (bandas.ContainsKey(banda))
            {
                List<int> notas = bandas[banda];
                double media = notas.Average();
                Console.WriteLine($"A media da banda {banda} é {media}");

                //int counter = 1;
                /*foreach (var band in bandas.Values)
                {
                    Console.WriteLine($"As notais atuais da banda {banda} são:\n{counter + ". " + band}");
                    double media = band.Average();
                    Console.WriteLine($"A media da banda {banda} é {media}");
                }*/
            }
            else
            {
                Console.WriteLine($"A banda {banda} nao foi encontrada");
            }
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
            
        }

        private static void AvaliarBandas()
        {
            Console.Clear();
            Console.WriteLine(@"
░█▀▀█ ▀█░█▀ █▀▀█ █░░ ░▀░ █▀▀█ █▀▀█ 　 ▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ 
▒█▄▄█ ░█▄█░ █▄▄█ █░░ ▀█▀ █▄▄█ █▄▄▀ 　 ▒█▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ 
▒█░▒█ ░░▀░░ ▀░░▀ ▀▀▀ ▀▀▀ ▀░░▀ ▀░▀▀ 　 ▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀
");
            Console.Write("Digite a banda que quer avaliar: ");
            string banda = Console.ReadLine();
            if (bandas.ContainsKey(banda))
            {
                Console.Write($"Qual nota a banda {banda} merece? ");
                int nota = int.Parse(Console.ReadLine());
                bandas[banda].Add(nota);
                Console.WriteLine($"A nota foi registrada com sucesso para a banda {banda}");
            } else
            {
                Console.WriteLine($"A banda {banda} nao foi encontrada");
            }
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

        private static void ExibirBandas()
        {
            Console.Clear();
            Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ █▀▀ 　 ▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ █▀▀▄ █▀▀█ █▀▀ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ ▀▀█ 　 ▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █▄▄█ █░░█ █▄▄█ ▀▀█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀ 　 ▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀
");
            if (bandas.Keys.Count == 0)
            {
                Console.WriteLine("Nenhuma banda registrada ainda.");
            }
            else
            {
                int counter = 1;
                foreach (var band in bandas.Keys)
                {
                    Console.Write($"{counter}. ");
                    Console.WriteLine(band);
                    counter++;
                }
                /*foreach (var band in bandas)
                {
                    Console.Write($"Banda: {band.Key} | Nota: {band.Value}");
                }*/
            }
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

        private static void RegistrarBanda()
        {
            Console.Clear();
            Console.WriteLine(@"
▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ 　 █▀▀▄ █▀▀ 　 ▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ █▀▀ 
▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █░░█ 　 █░░█ █▀▀ 　 ▒█▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ ▀▀█ 
▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀▀▀▀ 　 ▀▀▀░ ▀▀▀ 　 ▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀
");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string bandaRegistrada = Console.ReadLine();
            bandas.Add(bandaRegistrada, new List<int>());
            Console.WriteLine($"A banda {bandaRegistrada} foi registrada");
            //Thread.Sleep(2000);
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }


    }
}
