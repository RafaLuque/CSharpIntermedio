using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_02Sink_CallBack
{
    class cTiendaSink : IEventosRefri
    {
        public void EReservasBajas(int pKilos)
        {
            // Aqui se coloca el código necesario para ejecutar cuando suceda el evento
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Le enviamos los viveres");
            Console.WriteLine("--> Seran {0} kilos", pKilos);
        }

        public void EDescongelado(int pGrados)
        {
            // Hadler vacio
        }
    }
}
