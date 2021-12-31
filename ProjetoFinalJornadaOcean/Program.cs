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
            //Nova instancia da classe de visualização do elevador
            ConsoleViewElevador viewElevador = new ConsoleViewElevador();
            //Inicializando painel de interação da view
            viewElevador.UsarElevador();
        }
    }
}
