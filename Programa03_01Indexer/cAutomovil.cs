using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_01Indexer
{
    public class cAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public cAutomovil(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}",modelo);
            Console.WriteLine("costo {0} con una tenencia de {1}", costo,tenencia);
            Console.WriteLine("--------------------");
        }
    }
}
