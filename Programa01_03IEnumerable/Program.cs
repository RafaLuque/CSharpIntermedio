﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_03IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            cContenedora datos = new cContenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }
            Console.Read();
        }
    }
}
