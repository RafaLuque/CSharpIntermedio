using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_03IEnumerable
{
    public class cContenedora: IEnumerable
    {
        private int[] valores = new int[10];

        public cContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }

        //Implementamos el GetEnumerator necesario por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Instanciamos el enumerador y lo regresamos
            return (new ContenedorEnum(valores));
        }
    }

    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int position = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public bool MoveNext()
        {
            position++;
            if (position < arreglo.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[position];
            }
        }

    }
}
