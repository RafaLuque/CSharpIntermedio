using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    class cSuma: IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();


        // Metodos a implementar
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}", r);
            resultados.Add(r);
        }


        // Metodos propios de la clase
        public void mostrarResultados()
        {
            foreach (var r in resultados)
                Console.WriteLine(r);
        }
    }
}
