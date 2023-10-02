using System;

namespace quinta_practica
{
    class MayorCien
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n4 = int.Parse(Console.ReadLine());
            int contador = 0;
            if(n > 100){
                Console.WriteLine(n);
                contador++;
            }
            if(n2 > 100){
                Console.WriteLine(n2);
                contador++;
            }
            if(n3 > 100){
                Console.WriteLine(n3);
                contador++;
            }
            if(n4 > 100){
                Console.WriteLine(n4);
                contador++;
            }
            if(contador != 0){
                Console.WriteLine("Son mayores a 100...");
            }
        }
    }
}