using System;

namespace segunda_practica
{
    class PosNeg
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            if(n == 0){
                Console.WriteLine("El numero es 0");
            }else if(n > 0){
                Console.WriteLine("El numero es positivo");
            }else{
                Console.WriteLine("El numero es negativo");
            }
        }
    }
}