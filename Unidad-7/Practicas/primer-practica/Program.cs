using System;

namespace primer_practica
{
    class VectorMayor
    {
        static void Main()
        {
            int[] lista = new int[10];
            int n = 0;
            for(int x = 0; x < 10; x++)
            {
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                lista[x] = n;
            }
            //
            int maximo = 0, posicion = 0;
            maximo = lista[0];
            for(int x = 0; x < 10; x++)
            {
                if(lista[x] > maximo)
                {
                    maximo = lista[x];
                    posicion = x + 1;
                }
            }
            Console.WriteLine("El valor maximo es " + maximo + " en la posicion " + posicion);
        }
    }
}