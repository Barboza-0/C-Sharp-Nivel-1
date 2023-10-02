using System;

namespace quinta_practica
{
    class MaxMin
    {
        static void Main()
        {
            int mx = 0, mn = 0, n;
            bool banPar = false, banImpar = false;
            for(int x = 0; x < 20; x++)
            {
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                if(n % 2 == 0)
                {
                    if(banPar == false)
                    {
                        mx = n;
                        banPar = true;
                    }else if(n > mx)
                    {
                        mx = n;
                    }
                }else{
                    if(banImpar == false)
                    {
                        mn = n;
                        banImpar = true;
                    }else if(n < mn){
                        mn = n;
                    }
                }
                
            }
            Console.WriteLine("El maximo par es " + mx + " y el minimo impar es " + mn);
        }
    }
}