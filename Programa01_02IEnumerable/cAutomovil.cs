using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_02IEnumerable
{
    public class cAutomovil:IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;

        public cAutomovil(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }



        // Metodos interfaz

        public void CalcularTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}",modelo);
            Console.WriteLine("costo {0} con una tenencia de {1}", costo,tenencia);
            Console.WriteLine("Total: {0}", costo+tenencia);
            Console.WriteLine("--------------------");
        }
    }
}
