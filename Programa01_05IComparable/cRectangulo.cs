using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_05IComparable
{
    class cRectangulo:IComparable
    {
        private double ancho;
        private double alto;
        private double area;

        public cRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            calcularArea();
        }

        private void calcularArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("[{0}*{1}]={2}",ancho,alto,area);
        }

        //Implementación de Icomparable
        int IComparable.CompareTo(object obj)
        {
            //Hacemos type cast con el objeto con el cual vamos a comparar.
            cRectangulo temp = (cRectangulo)obj;

            //Si somos mas grandes que el objeto regresamos 1
            if (area > temp.area)
                return 1;

            //Si somos mas queños que el objto regresamos -1
            if (area < temp.area)
                return -1;

            //Somos iguales al objeto regresamos 0
            return 0;
        }
    }
}
