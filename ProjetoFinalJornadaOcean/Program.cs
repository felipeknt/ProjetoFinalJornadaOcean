using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFinalJornadaOcean.Views;

namespace ProjetoFinalJornadaOcean
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleViewElevador viewElevador = new ConsoleViewElevador();
            viewElevador.UsarElevador();
        }
    }
}
