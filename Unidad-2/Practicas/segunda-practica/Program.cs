using System;

namespace segunda_practica
{
    class elevado_al_cubo
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());

            int resultado = n * n * n;

            Console.WriteLine("El resultado es " + resultado);
        }
    }
}