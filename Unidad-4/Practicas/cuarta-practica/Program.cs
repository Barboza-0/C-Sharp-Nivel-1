using System;

namespace cuarta_practica
{
    class TresNumeros
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n3 = int.Parse(Console.ReadLine());
            int suma = n + n2;
            int producto = n2 * n3;
            if(suma > producto){
                Console.WriteLine("La suma es MAYOR al producto..");
            }else{
                Console.WriteLine("La suma es MENOR al producto..");
            }
        }
    }
}