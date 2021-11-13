using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_04DelegadoSencillo
{
    class cRadio
    {
        //Este metodo actuara como delegado
        public static void MetodoRadio(string pMensaje) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estamos en la case radio");
            Console.WriteLine("Este es tu mensaje {0}", pMensaje);
        }
    }
}
