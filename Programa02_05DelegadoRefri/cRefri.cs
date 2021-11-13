using System;
using System.Collections;

namespace Programa03_05DelegadoRefri
{
    class cRefri
    {
        // Aqui van los delegados
        public delegate void dReservasBajas(int pKilos);
        public delegate void dDescongelado(int pGrados);

        private int kilosAlimeintos=0;
        private int grados = 0;

        // Aqui están las variables que usaremos para invocar
        private dReservasBajas delReservas;
        private dDescongelado delDescongelado;

        public cRefri(int pKilos, int pGrados)
        {
            kilosAlimeintos = pKilos;
            grados = pGrados;
        }

        //Estos metodos permiten referenciar las variables
        public void AdicionaMetodoReservas(dReservasBajas pMetodo) {
            delReservas = pMetodo;
        }
        public void AdicionaMetodoDescongelado(dDescongelado pMetodo)
        {
            delDescongelado = pMetodo;
        }

        //Propiedades necesarias
        public int Kilos { get { return kilosAlimeintos; } }
        public int Grados { get { return grados; } }


        public void Trabjar(int pConsumo)
        {
            //Actualizamos kilos del refri
            kilosAlimeintos -= pConsumo;

            //subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimeintos, grados);

            //Hay que verificar si se cumple la condición para invocar los hadles del evento.

            //Esta es la condición del evento para los kilos
            if (kilosAlimeintos < 10)
                delReservas(kilosAlimeintos);

            //Esta es la condición del evento para la temperatura
            if (grados >0)
                delDescongelado(grados);
        }
    }
}
