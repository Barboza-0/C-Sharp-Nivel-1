using System;

namespace tercer_practica
{
    class Listas
    {
        static void Main()
        {
            int contadorLista = 0, n = 0;
            Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
            while(n > -1)
            {
                int contador = 0;
                contadorLista++;
                while(n > 0)
                {
                    contador++;
                    Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La lista " + contadorLista + " tiene " + contador + " numeros..");
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
            }
        }
    }
}