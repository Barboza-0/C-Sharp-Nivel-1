using System;

namespace segunda_practica
{
    class Dieznros
    {
        static void Main()
        {
            
            int n, mx = 0;
            for(int x = 0; x < 10; x++)
            {
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                if(x == 0)
                {
                    mx = n;
                }else if(n > mx){
                    mx = n;
                }
            }
            Console.Write("El maximo es " + mx);
        }
    }
}