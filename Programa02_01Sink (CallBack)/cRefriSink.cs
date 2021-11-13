using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_01Sink_CallBack
{
    class cRefriSink: IEventosRefri   
    {
        // Esta es la clase sink
        // Aqui colocamos los hadles de los eventos definidos en la interfaz
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca el código necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Reservas bajas de alimentos");
            Console.WriteLine("--> Quedan {0} kilos", pKilos);
        }
    }
}
