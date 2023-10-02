using System;

namespace segunda_practica
{
    class Promedio
    {
        static void Main()
        {
            int[] lista = new int[10];
            int n = 0, acumulador = 0, promedio = 0;
            for(int x = 0; x < 10; x++)
            {
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                lista[x] = n;
                acumulador += n;
            }
            promedio = acumulador / 10;
            Console.WriteLine("El promedio es " + promedio);
            for(int x = 0; x < 10; x++)
            {
                if(lista[x] > promedio)
                {
                    Console.Write(lista[x] + " es mayor al promedio..  _");
                }
            }
        }
    }
}