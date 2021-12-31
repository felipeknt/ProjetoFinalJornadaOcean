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
        Elevador elevador = new Elevador();

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
        }

        private void Painel() {
            Console.WriteLine("╔══════════════════════╗");
            Console.WriteLine("║                      ║");
            Console.WriteLine("║                      ║");
            Console.WriteLine("║                      ║");
            Console.WriteLine("║                      ║");
            Console.WriteLine("║                      ║");
            Console.WriteLine("║                      ║");
            Console.WriteLine("║                      ║");
            Console.WriteLine("╚══════════════════════╝");

        }
    }
}
