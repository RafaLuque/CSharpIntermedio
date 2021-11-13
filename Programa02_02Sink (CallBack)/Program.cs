using System;

namespace Programa02_02Sink_CallBack
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
            cTiendaSink sink2 = new cTiendaSink();

            //Añadimos el sink al refri
            miRefri.AgregarSink(sink1);
            miRefri.AgregarSink(sink2);

            //El refri hace su trabajo
            while (miRefri.Kilos > 0 && sink1.Paro==false)
            {
                miRefri.Trabjar(rnd.Next(1, 5));
            }
            Console.Read();
        }
    }
}
