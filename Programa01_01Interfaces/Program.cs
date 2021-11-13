using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=1;
            string valor;
            double valorA, valorB;

            IOperacion operacion = new cSuma();

            while (opcion!=0)
            {
                Console.WriteLine("1-suma, 2- resta, 0-salir");
                Console.WriteLine("¿Que operación desea?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt16(valor);

                Console.WriteLine("Dame valor de A");
                valor = Console.ReadLine();
                valorA = Convert.ToDouble(valor);

                Console.WriteLine("Dame valor de B");
                valor = Console.ReadLine();
                valorB = Convert.ToDouble(valor);


                // Polimorfismo.
                switch (opcion)
                {
                    case 1:
                        operacion = new cSuma();
                        break;
                    case 2:
                        operacion = new cResta();
                        break;
                    default:
                        break;
                }


                //Agui nuestro programa trabaja en terminos de concepto Operación,
                //en lugar de terminos de cosas concretas como suma, resta
                operacion.calcular(valorA, valorB);
                operacion.mostrar();
            }
        }
    }
}
