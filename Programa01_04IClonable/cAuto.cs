using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_04IClonable
{
    class cAuto:IAutomovil, ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        public cAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }

        public double Costo { get { return costo; }  set { costo = value; } }
        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        // Metodos interfaz
        public void CalcularTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("costo {0} con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total: {0}", costo + tenencia);
            Console.WriteLine("--------------------");
        }

        //Metodo para implementar a IClonable
        public object Clone()
        {
            cAuto temp = new cAuto(modelo, costo);
            temp.Tenencia = tenencia;

            return temp;
        }
    }
}
