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

        static List<string> bandas = new List<string>();

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
                case 4:
                    Console.WriteLine("\nAvaliando bandas...");
                    break;
                case -1:
                    Console.WriteLine("\nObrigado :)");
                    break;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }
        }

        private static void ExibirBandas()
        {
            Console.Clear();
            Console.WriteLine(@"
▒█▀▀█ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ █▀▀ 　 ▒█▀▀█ █▀▀ █▀▀▀ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ █▀▀█ █▀▀▄ █▀▀█ █▀▀ 
▒█▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ ▀▀█ 　 ▒█▄▄▀ █▀▀ █░▀█ ▀█▀ ▀▀█ ░░█░░ █▄▄▀ █▄▄█ █░░█ █▄▄█ ▀▀█ 
▒█▄▄█ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀ 　 ▒█░▒█ ▀▀▀ ▀▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░▀▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀
");
            if (bandas.Count == 0)
            {
                Console.WriteLine("Nenhuma banda registrada ainda.");
            }
            else
            {
                int counter = 1;
                foreach (var band in bandas)
                {
                    Console.Write($"{counter}. ");
                    Console.WriteLine(band);
                    counter++;
                }
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
            bandas.Add(bandaRegistrada);
            Console.WriteLine($"A banda {bandaRegistrada} foi registrada");
            //Thread.Sleep(2000);
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }


    }
}
