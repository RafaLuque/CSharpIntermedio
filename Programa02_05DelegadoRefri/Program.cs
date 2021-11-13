using System;

namespace Programa03_05DelegadoRefri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            cRefri miRefri = new cRefri(50, -20);
            Random rnd = new Random();

            //Adicionamos los hadles
            miRefri.AdicionaMetodoReservas(new cRefri.dReservasBajas(InformeGrados));
            miRefri.AdicionaMetodoDescongelado(new cRefri.dDescongelado(InformeGrados));
            

            //El refri hace su trabajo
            while (miRefri.Kilos >0)
            {
                miRefri.Trabjar(rnd.Next(1, 5));
            }
            Console.Read();
        }

        public static void InformeKilos(int pKilos) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--> Reservas bajas de alimientos, estoy a nivel de main");
            Console.WriteLine("--> Quedan {0} kilos", pKilos);
        }

        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--> Se descongela el refri, estoy a nivel de main");
            Console.WriteLine("--> Esta a {0} grados", pGrados);
        }




    }
}
