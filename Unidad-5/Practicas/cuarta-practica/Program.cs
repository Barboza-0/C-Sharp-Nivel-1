using System;

namespace cuarta_practica
{
    class Primo
    {
        static void Main()
        {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            int au = 0;
            for(int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                {
                    au++;
                }
            }
            if(au == 2)
            {
                Console.WriteLine("Es un numero primo");
            }else{
                Console.WriteLine("No es un numero primo");
            }
        }
    }
}