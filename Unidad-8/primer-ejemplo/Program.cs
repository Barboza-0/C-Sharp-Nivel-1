using System;

namespace primer_ejemplo
{
    class Funciones
    {
        static void Main()
        {
            int s = 0;
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero: "); int n2 = int.Parse(Console.ReadLine());
            numeroPar(ref n);
            s = suma(n, n2);
            Console.WriteLine("La suma es " + s);
        }
        static void numeroPar(ref int n)
        {
            if(n % 2 == 0)
            {
                Console.WriteLine("Primer numero par..");
            }else{
                Console.WriteLine("Primer numero impar..");
            }
        }
        static int suma(int n, int n2)
        {
            int r;
            r = n + n2;
            return r;
        }
    }
}