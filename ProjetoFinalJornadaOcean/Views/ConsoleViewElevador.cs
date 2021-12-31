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

        public void UsarElevador() {
            ConfiguracaoConsole();
            Painel();
            Console.ReadKey();
        }
        public static void LimparConsole(){
            Console.Clear();
        }

        private void ConfiguracaoConsole() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Projeto elevador";
        }

        private void Painel() {
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
    }
}
