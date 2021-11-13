using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04IClonable
{
    class Program
    {
        static void Main(string[] args)
        {
            cAuto auto1 = new cAuto("March", 1700000);
            cAuto auto2 = (cAuto)auto1.Clone();

            auto1.MuestraInformacion();
            auto2.MuestraInformacion();
            Console.WriteLine("==============");

            auto1.Costo = 250000;
            Console.WriteLine("Cambiamos el costo de Auto1");

            auto1.MuestraInformacion();
            auto2.MuestraInformacion();
            Console.WriteLine("--------------");
            Console.Read();
        }
    }
}
