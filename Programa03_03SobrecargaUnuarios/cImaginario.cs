using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa03_03SobrecargaUnuarios
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

        //Sobrecarga de los operadores Unuario
        public static cImaginario operator ++ (cImaginario i)
        {
            var temp = new cImaginario(i.Entero+1, i.Imaginario+1);
            return temp;
        }

        public static cImaginario operator -- (cImaginario i)
        {
            var temp = new cImaginario(i.Entero - 1, i.Imaginario - 1);
            return temp;
        }


        public static cImaginario operator +(cImaginario i1, cImaginario i2)
        {
            double re = 0;
            double ri = 0;

            re = i1.Entero + i2.Entero;
            ri = i1.imaginario + i2.Imaginario;

            var temp = new cImaginario(re, ri);
            return temp;
        }

        public override bool Equals(object obj)
        {
            if (obj is cImaginario)
            {
                cImaginario temp = (cImaginario)obj;
                if (imaginario == temp.imaginario && entero == temp.entero)
                    return true;
            }
            return false;
        }

        public static bool operator ==(cImaginario i1, cImaginario i2)
        {
            return i1.Equals(i2);
        }

        public static bool operator !=(cImaginario i1, cImaginario i2)
        {
            return !(i1.Equals(i2));
        }
    }
}
