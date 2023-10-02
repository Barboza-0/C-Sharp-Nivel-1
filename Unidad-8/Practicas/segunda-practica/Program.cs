using System;
using System.Diagnostics.Contracts;

namespace segunda_practica
{
    class segunda_practica
    {
        static void Main()
        {
            int n = 0, contador = 0;
            for(int x = 0; x < 20; x++)
            {
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                contador += Par(n);
            }
            Console.WriteLine("El total de numeros pares es de " + contador);
        }

        static int Par(int n1)
        {
            int indice = 0;
            if(n1 % 2 == 0)
            {
                indice++;
            }
            return indice;
        }
    }
}