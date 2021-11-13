using System;
using System.Collections;

namespace Programa02_02Sink_CallBack
{
    class cRefri
    {
        
        // Aqui guardamos todos los sinks con los que se comuncara el refri
        private ArrayList listaSinks = new ArrayList();

        private int kilosAlimeintos=0;
        private int grados = 0;

        public cRefri(int pKilos, int pGrados)
        {
            kilosAlimeintos = pKilos;
            grados = pGrados;
        }

        // Con este método adcionamos un sink
        public void AgregarSink(IEventosRefri pSink)
        {
            if (pSink != null)
                listaSinks.Add(pSink);
        }

        // Con este metodod eliminamos un sink
        public void EliminarSink(IEventosRefri pSink)
        {
            if (listaSinks.Contains(pSink))
                listaSinks.Remove(pSink);
        }

        //Propiedades necesarias
        public int Kilos { get { return kilosAlimeintos; } }
        public int Grados { get { return grados; } }

        public void Trabjar(int pConsumo)
        {
            //Actualizamos kilos del refri
            kilosAlimeintos -= pConsumo;

            //subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimeintos, grados);

            //Hay que verificar si se cumple la condición para invocar los hadles del evento.

            //Esta es la condición del evento.
            if (kilosAlimeintos<10)
            {
                //Invocamos los hadles de cada sink
                foreach (IEventosRefri hadler in listaSinks)
                {
                    hadler.EReservasBajas(kilosAlimeintos);
                }
            }

            //Esta es la condición para el nuevo evento de descongelado
            if (grados > 0)
            {
                //Invocamos los hadles de cada sink
                foreach (IEventosRefri hadler in listaSinks)
                {
                    hadler.EDescongelado(kilosAlimeintos);
                }
            }
        }
    }
}
