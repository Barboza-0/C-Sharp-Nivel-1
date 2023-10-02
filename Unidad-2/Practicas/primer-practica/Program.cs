using System;

namespace Practica_Calculadora
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero para sumar: "); int n2 = int.Parse(Console.ReadLine());

            int resultado = n + n2;

            Console.WriteLine("El resultado es " + resultado);
        }
    }
}