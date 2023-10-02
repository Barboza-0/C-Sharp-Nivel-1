using System;

namespace primer_practica
{
    class Primos
    {
        static void Main()
        {
            int n = 0, conPrimos = 0;
            for(int x = 0; x < 10; x++)
            {
                int con = 0;
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                for(int y = 1; y <= n; y++)
                {
                    if(n % y == 0)
                    {
                        con++;
                    }
                }
                if(con == 2)
                {
                    conPrimos++;
                }
            }
            Console.WriteLine("La cantidad de primos es " + conPrimos);
        }
    }
}