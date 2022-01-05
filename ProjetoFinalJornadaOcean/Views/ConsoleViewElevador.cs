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

        public void UsarElevadorAsync()
        {
            ConfiguracaoConsole();
            Console.WriteLine("Quantos andares: ");
            int qtdAndar = int.Parse(Console.ReadLine());
            Console.WriteLine("Capacidade maxima de pessoas: ");
            int qtdMaxima = int.Parse(Console.ReadLine());
            e.Inicializar(qtdAndar, qtdMaxima);
            string opcao = "";
            do
            {
                //ConfiguracaoConsole();
                Painel();
                Entrada(Console.ReadLine());
                //await Task.Delay(3000);
                LimparConsole();
            } while (opcao != "z" || opcao != "Z");
        }

        public static void LimparConsole() {
            Task.Delay(3000);
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
