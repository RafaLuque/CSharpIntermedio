using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02Sink_CallBack
{
    class cRefriSink: IEventosRefri   
    {
        // Esta es la clase sink
        private bool paro = false;
        public bool Paro { get { return paro; } }


        // Aqui colocamos los hadles de los eventos definidos en la interfaz
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca el código necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Reservas bajas de alimentos");
            Console.WriteLine("--> Quedan {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> El refri se descongela");

            if (pGrados > 0)
                paro = true;
        }
    }
}
