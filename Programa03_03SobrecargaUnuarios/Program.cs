using System;

namespace Programa03_03SobrecargaUnuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            var im1 = new cImaginario(1, 2);
            var im2 = new cImaginario(3, 4);

            Console.WriteLine(im1);
            im1++;
            Console.WriteLine(im1);
            Console.WriteLine("---------------------");

            Console.WriteLine(im2);
            im2--;
            Console.WriteLine(im2);
            Console.WriteLine("---------------------");

            Console.WriteLine(im1);
            im1+=im2;
            Console.WriteLine(im1);
            Console.WriteLine("---------------------");


            var im3 = new cImaginario(1, 2);
            var im4 = new cImaginario(3, 4);
            var im5 = new cImaginario(1, 2);

            if (im3 == im5)
                Console.WriteLine("Son iguales");

            if (im4 != im5)
                Console.WriteLine("Son diferentes");


            Console.Read();

        }
    }
}
