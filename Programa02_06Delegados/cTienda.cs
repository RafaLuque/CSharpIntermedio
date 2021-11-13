using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_06Delegados
{
    class cTienda
    {
        public static void MandaViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--> Le enviamos los viveres, estoy en la tienda");
            Console.WriteLine("--> Seran {0} kilos", pKilos);
        }
    }
}
