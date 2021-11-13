using System;

namespace Programa03_04DelegadoSencillo
{
    class Program
    {
        //Definimos el delegado on las caracteristicas que nos interesa
        public delegate void MiDelegado(string m);
        static void Main(string[] args)
        {
            //Creamos un objeto del delegado y lo referenciamos a un metodo.
            MiDelegado delegado = new MiDelegado(cRadio.MetodoRadio);

            //Ahora por medio del delegado hacemos uso del metodo
            delegado("Hola a todos");

            //Hacemos que apunto a otro metodo
            delegado = new MiDelegado(cPastel.MetodoPastel);

            //Ahora invocamos el otro metodo
            delegado("Feliz cumpleaños");
        }
    }
}
