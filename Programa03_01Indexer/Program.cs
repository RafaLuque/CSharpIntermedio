using System;

namespace Programa03_01Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            //creamos la tienda
            cTiendaAutos miTienda = new();

            // Obtenemos un auto
            cAutomovil miAuto = miTienda[1];
            miAuto.MuestraInformacion();

            //Colocamos un auto
            cAutomovil otroAuto = new cAutomovil("Vocho", 85000);
            miTienda[1] = otroAuto;

            //Imprimimos toda la tienda
            for (n = 0; n < 4; n++)
                miTienda[n].MuestraInformacion();
        }
    }
}
