using System;

namespace quinta_practica
{
    class Decreciente
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n4 = int.Parse(Console.ReadLine());

            if(n > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("Los numero estan ordenados de manera decreciente..");
            }else{
                Console.WriteLine("Los numeros están desordenados..");
            }
        }
    }
}