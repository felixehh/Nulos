using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro();
            miCarro.Marca = "Tsuru";
            miCarro.Kilometraje = 100000;

            Console.WriteLine("Marca: " + miCarro.Marca);
            Console.WriteLine("Km: " + miCarro.Kilometraje);

            if(miCarro.DueñoCarro != null)
            {
                Console.WriteLine("Dueño: " + miCarro.DueñoCarro.Nombre);
            }
            else
            {
                Console.WriteLine("No se encontro dueño");
            }

            //Console.WriteLine("Mi carro tiene: " + miCarro.Kilometraje + " km recorridos");

            if (miCarro == null)
            {
                Console.WriteLine("no ha sido asignado un valor");
            }

            Console.ReadLine();
        }
    }
}
