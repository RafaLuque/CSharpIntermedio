using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_04DelegadoSencillo
{
    class cPastel
    {
        //Este metodo actuara como delegado
        public static void MetodoPastel(string pMensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El pastel llevará el mnsaje de {0}", pMensaje);
        }
    }
}
