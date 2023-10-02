using System;

namespace cuarta_practica
{
    class Menor
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n4 = int.Parse(Console.ReadLine());
            int menor = n;
            if(n2 < menor){
                menor = n2;
            }
            if(n3 < menor){
                menor = n3;
            }
            if(n4 < menor){
                menor = n4;
            }
            Console.WriteLine("El numero menor es " + menor);
        }
    }
}