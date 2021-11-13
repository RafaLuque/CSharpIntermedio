using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa04_01SerializacionBinaria
{
    [Serializable]
    class cAuto
    {
        private double costo;
        private string modelo;

        public cAuto(string pModelo, double pCosto)
        {
            costo = pCosto;
            modelo = pModelo;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("---------------------");
        }
    }
}
