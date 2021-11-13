using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_02SobrecargaBinario
{
    class cImaginario
    {
        //Atributos
        private double entero;
        private double imaginario;

        public cImaginario(double pEntero, double pImaginario)
        {
            entero = pEntero;
            imaginario = pImaginario;
        }

        //Propiedades
        public double Entero { get { return entero; } set { entero = value; } }
        public double Imaginario { get { return imaginario; } set { imaginario = value; } }


        public override string ToString()
        {
            if (imaginario < 0)
                return string.Format("({0} {1}i)", entero, imaginario);
            else
                return string.Format("({0} + {1}i)", entero,imaginario);
        }

        //Sobrecarga de los operadores binarios
        public static cImaginario operator + (cImaginario i1, cImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero + i2.Entero;
            ri = i1.imaginario + i2.Imaginario;

            var temp = new cImaginario(re, ri);
            return temp;
        }

        public static cImaginario operator - (cImaginario i1, cImaginario i2)
        {
           double re = i1.Entero - i2.Entero;
           double ri = i1.Imaginario - i2.Imaginario;

            var temp = new cImaginario(re, ri);
            return temp;
        }

        public static cImaginario operator * (cImaginario i1, cImaginario i2)
        {
            double re = (i1.Entero * i2.Entero) + (i1.Imaginario * i2.Imaginario); 
            double ri = (i1.Entero * i2.Imaginario) - (i1.Imaginario * i2.Entero);

            var temp = new cImaginario(re, ri);
            return temp;
        }

        public static cImaginario operator / (cImaginario i1, cImaginario i2)
        {
            double re = ((i1.Entero * i2.Entero) + (i1.Imaginario * i2.Imaginario)) / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));
            double ri = ((i1.Imaginario * i2.Entero) - (i1.Entero * i2.Imaginario)) / ((i2.Entero * i2.Entero) + (i2.Imaginario * i2.Imaginario));

            var temp = new cImaginario(re, ri);
            return temp;
        }

    }
}
