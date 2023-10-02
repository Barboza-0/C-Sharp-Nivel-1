
using System;
namespace primer_practica
{
    class mayor10
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            if(n > 10){
                Console.WriteLine(n + " es mayor a 10");
            }else if(n == 10){
                Console.WriteLine("Es igual a 10");
            }else{
                Console.WriteLine(n + " no es mayor a 10");
            }
        }
    }
}