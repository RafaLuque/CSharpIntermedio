using System;

namespace Programa03_06Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el refri
            cRefri miRefri = new cRefri(70, -20);
            Random rnd = new Random();

            //Variables para el multicasting, necesitamos la instancia para poder adicionar o eliminar
            dReservasBajas kilos1 = new dReservasBajas(InformeKilos);
            dReservasBajas kilos2 = new dReservasBajas(cTienda.MandaViveres);
            dDescongelado desc1 = new dDescongelado(InformeGrados);

            //Adicionamos los hadles
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(desc1);


            //El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabjar(rnd.Next(1, 5));
            }

            ////////////////////////////////////

            //Eliminamos los hadles
            miRefri.EliminaMetodoReservas(kilos2);

            miRefri.Kilos = 50;
            miRefri.Grados = -15;

            //El refri hace su trabajo
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabjar(rnd.Next(1, 5));
            }



        }

        public static void InformeKilos(int pKilos)
        {
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
