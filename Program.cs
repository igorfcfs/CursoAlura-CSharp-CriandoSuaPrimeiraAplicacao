using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirMensagem();
            ExibirOpcoesMenu();
        }

        static void ExibirMensagem()
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
                    Console.WriteLine("\nRegistrando banda...");
                    break;
                case 2:
                    Console.WriteLine("\nMostrando bandas...");
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
    }
}
