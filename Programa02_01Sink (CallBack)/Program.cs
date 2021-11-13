using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01Sink_CallBack
{
    class Program
    {

        static void Main(string[] args)
        {
            // Creamos el refri
            cRefri miRefri = new cRefri(50, -20);

            Random rnd = new Random();

            //Creamos el sink
            //Sink1 tiene el código se se ejecutara cuando suceda el evento.
            cRefriSink sink1 = new cRefriSink();

            //Añadimos el sink al refri
            miRefri.AgregarSink(sink1);

            //El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabjar(rnd.Next(1,5));
            }
            Console.Read();
        }
    }
}
