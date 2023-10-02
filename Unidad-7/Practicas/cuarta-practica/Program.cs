using System;

namespace cuarta_practica
{
    class Articulos
    {
        static void Main()
        {
            int[] articulo = new int[15];
            int na = 0, nact = 0, cantidad = 0;
            Console.Write("Ingrese el codigo de articulo: "); na = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad vendida: "); cantidad = int.Parse(Console.ReadLine());
            while(na != 0)
            {
                nact = na;
                while(nact == na)
                {
                    articulo[nact - 1] = cantidad;
                    Console.Write("Ingrese el codigo de articulo: "); na = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad vendida: "); cantidad = int.Parse(Console.ReadLine());
                }
            }
            int numero = 0;
            for(int x = 0; x < 14; x++)
            {
                if(articulo[x] > articulo[x + 1])
                {
                    numero = x + 1;
                }
            }
            Console.WriteLine("El articulo más vendido fue el " + numero);
            for(int x = 0; x < 15; x++)
            {
                if(articulo[x] == 0)
                {
                    Console.WriteLine("No hubo ventas del articulo " + (x + 1));
                }
            }
            Console.WriteLine("El articulo 10 vendió " + articulo[9]);
        }
    }
}