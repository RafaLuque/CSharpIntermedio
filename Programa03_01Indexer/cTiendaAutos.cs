using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01Indexer
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

        //Aqui creamos el indexer
        public cAutomovil this[int indice]
        {
            //Usamos un get para obtener el elemento en ese indice
            get { return disponibles[indice]; }

            //Usamos set para colocar un elemento en ese indice
            set { disponibles[indice]= value; }
        }
    }
}
