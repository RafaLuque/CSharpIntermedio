using System;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Programa04_01SerializacionBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";

            Console.WriteLine("1) crear y serializar auto, 2) leer autos");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                //Creamos el objeto cAuto
                string modelo = "";
                double costo = 0;

                Console.WriteLine("Dame el modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Dame el costo");
                valor = Console.ReadLine();
                costo = Convert.ToDouble(valor);

                cAuto miAuto = new cAuto(modelo, costo);

                Console.WriteLine("Auto a serializar");
                 miAuto.MuestraInformacion();

                Console.WriteLine("--- Serializamos ---");

                // Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // Se crea el stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);

                // Serializamos
                formateador.Serialize(miStream, miAuto);

                // Cerramos el stream
                miStream.Close();
            }

            if (opcion == 2)
            {
                Console.WriteLine("--- Deserializamos ---");

                //Seleccionamos el formateador
                BinaryFormatter formateador = new BinaryFormatter();

                // Creamos stream
                Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);

                // Deserializamos
                cAuto miAuto = (cAuto)formateador.Deserialize(miStream);

                // Cerramos el stream
                miStream.Close();

                // Usamos el objeto
                Console.WriteLine("El auto deserializado es");
                miAuto.MuestraInformacion();
            }
        }
    }
}
