using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_05IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            cRectangulo[] rects = new cRectangulo[5];
            rects[0] = new cRectangulo(7,5);
            rects[1] = new cRectangulo(6,4);
            rects[2] = new cRectangulo(4,3);
            rects[3] = new cRectangulo(7,6);
            rects[4] = new cRectangulo(5,7);

            //Imprimimos arreglo original
            foreach (var r in rects)
                Console.WriteLine(r);

            Console.WriteLine("-------------------------");

            //Hacemos uso de sort, el cual necesita la implementación de IComparable.
            Array.Sort(rects);

            //Imprimimos arreglo ordenado
            foreach (var r in rects)
                Console.WriteLine(r);

            Console.Read();
        }
    }
}
