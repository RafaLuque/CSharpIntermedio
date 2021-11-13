using System;

namespace Programa03_02SobrecargaBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            var im1 = new cImaginario(1, 2);
            var im2 = new cImaginario(3, 4);
            cImaginario imr;

            //Hacemos la suma
            imr = im1 + im2;

            Console.WriteLine("{0} + {1} = {2}", im1,im2,imr);

            //Hacemos la resta
            imr = im1 - im2;

            Console.WriteLine("{0} - {1} = {2}", im1, im2, imr);

            //Hacemos la multiplicacion
            imr = im1 * im2;

            Console.WriteLine("{0} * {1} = {2}", im1, im2, imr);

            //Hacemos la division
            imr = im1 / im2;

            Console.WriteLine("{0} / {1} = {2}", im1, im2, imr);

            Console.Read();
        }
    }
}
