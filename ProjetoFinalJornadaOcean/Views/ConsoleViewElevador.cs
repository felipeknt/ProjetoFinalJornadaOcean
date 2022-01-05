using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinalJornadaOcean.Model;

namespace ProjetoFinalJornadaOcean.Views
{
    /// <summary>
    /// Classe de interação do elevador
    /// </summary>
    internal class ConsoleViewElevador
    {
        private string status = "Aguardando";

        //Nova instancia da classe Elevador
        Elevador e = new Elevador();

        public void UsarElevador()
        {
            ConfiguracaoConsole();
            Painel();
            Console.ReadKey();
        }
        public static void LimparConsole()
        {
            Console.Clear();
        }

        private void ConfiguracaoConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Projeto elevador";
        }

        private void Painel()
        {
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine($"║ Status: {status}   ║");
            Console.WriteLine($"║ Andar: {e.AndarAtual.ToString("00")}            ║");
            Console.WriteLine($"║ Pessoas: {e.Pessoas.ToString("00")}          ║");
            //Console.WriteLine("║                      ║");
            // Console.WriteLine("║                      ║");
            // Console.WriteLine("║                      ║");
            //Console.WriteLine("║                      ║");
            Console.WriteLine("╚══════════════════════╝");

        }

        private void Entrada(string t)
        {
            switch (t)
            {
                case "1":
                    Console.WriteLine("Opção 1 escolhida: Entrar");
                    e.Entrar();
                    break;
                case "2":
                    Console.WriteLine("Opção 2 escolhida: Sair");
                    e.Sair();
                    break;
                case "3":
                    Console.WriteLine("Opção 3 escolhida: Subir");
                    e.Subir();
                    break;
                case "4":
                    Console.WriteLine("Opção 4 escolhida: Descer");
                    e.Descer();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
