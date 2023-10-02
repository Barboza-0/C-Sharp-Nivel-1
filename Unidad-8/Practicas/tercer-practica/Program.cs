using System;

namespace tercer_practica
{
    class PromedioPrimo
    {
        static void Main()
        {
            int n = 0, i = 0, acu = 0, con = 0, promedio = 0;
            Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                i = Primo(n);
                if(i == 1)
                {
                    con++;
                    acu += n;
                }
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de los numeros primos es de " + promedio);
        }

        static int Primo(int n)
        {
            int contador = 0;
            for(int x = 1; x <= n; x++)
            {
                if(n % x == 0)
                {
                    contador++;
                }
            }
            if(contador == 2)
            {
                return 1;
            }else{
                return 0;
            }
        }
    }
}