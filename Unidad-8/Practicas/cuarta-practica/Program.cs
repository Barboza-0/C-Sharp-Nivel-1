using System;

namespace cuarta_practica
{
    class FunVoid
    {
        static void Main()
        {
            int n = 0, n2 = 0;
            Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
            PositivoNegativoCero(n, ref n2);
            if(n2 == 0)
                Console.WriteLine("Cero");
            else if(n2 > 0)
                Console.WriteLine("Positivo");
            else
                Console.WriteLine("Negativo");
        }

        static void PositivoNegativoCero(int a, ref int b)
        {
            if(a == 0)
                b = 0;
            else if(a > 0)
                b = 1;
            else
                b = -1;
        }
    }
}