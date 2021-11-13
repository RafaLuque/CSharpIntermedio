using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    class Program
    {
        /*
        public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }

        public interface IEnumerator
        {
            bool MoveNext();
            object Current { get; }
            void Reset;
        }
        */

        static void Main(string[] args)
        {
            cTiendaAutos tienda = new cTiendaAutos();

            //Recorremos cada uno de los elementos de la 
            //estructura que expone
            foreach (cAutomovil auto in tienda)
            {
                auto.CalcularTenencia(0.05);
                auto.MuestraInformacion();
            }
            Console.Read();
        }
    }
}
