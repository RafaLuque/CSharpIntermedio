using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    class cTiendaAutos
    {
        private cAutomovil[] disponibles;

        public cTiendaAutos()
        {
            disponibles = new cAutomovil[4];
            disponibles[0] = new cAutomovil("Soul",220000.50);
            disponibles[1] = new cAutomovil("Fit",175600.70);
            disponibles[2] = new cAutomovil("March",168900.00);
            disponibles[3] = new cAutomovil("Spark",160400.40);
        }

        public IEnumerator GetEnumerator()
        {
            // Regresamos la estructura que nos interasa que 
            // recorra el foreach, esta debe de implementar IEnumerator
            return disponibles.GetEnumerator();
        }
    }
}
