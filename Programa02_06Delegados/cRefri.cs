using System;
using System.Collections;

namespace Programa03_06Delegados
{
    // Aqui van los delegados
    public delegate void dReservasBajas(int pKilos);
    public delegate void dDescongelado(int pGrados);

    class cRefri
    {
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
        //Hacemos multicasting
        public void AdicionaMetodoReservas(dReservasBajas pMetodo) {
            delReservas += pMetodo;
        }
        public void EliminaMetodoReservas(dReservasBajas pMetodo)
        {
            delReservas -= pMetodo;
        }
        public void AdicionaMetodoDescongelado(dDescongelado pMetodo)
        {
            delDescongelado += pMetodo;
        }
        public void EliminaMetodoDescongelado(dDescongelado pMetodo)
        {
            delDescongelado -= pMetodo;
        }

        //Propiedades necesarias
        public int Kilos { get { return kilosAlimeintos; } set { kilosAlimeintos = Kilos; } }
        public int Grados { get { return grados; } set { grados = Grados; } }

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
