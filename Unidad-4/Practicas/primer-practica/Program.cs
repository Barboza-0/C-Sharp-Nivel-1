using System;

namespace primer_practica
{
    class Mixto
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: "); int n2 = int.Parse(Console.ReadLine());
            int resultado;
            if(n > n2){
                resultado = n - n2;
            }else if(n == n2){
                resultado = n + n2;
            }else{
                resultado = n * n2;
            }
            Console.WriteLine("El resultado es " + resultado);
        }
    }
}