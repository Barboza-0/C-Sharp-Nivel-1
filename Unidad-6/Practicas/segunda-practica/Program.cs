using System;

namespace segunda_practica
{
    class Lista0
    {
        static void Main()
        {
            int n = 0, por = 0, mxporc = 0, ng = 0, conOrd = 0;
            for(int x = 0; x < 5; x++)
            {
                Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                int con = 0, coni = 0, nact = 0, ban = 1;
                while(n != 0)
                {
                    if(n >= nact)
                    {
                        nact = n;
                    }else{
                        ban = 0;
                    }
                    con++;
                    if(n % 2 != 0)
                    {
                        coni++;
                    }
                    Console.Write("Ingrese un numero: "); n = int.Parse(Console.ReadLine());
                }
                if(ban == 0)
                {
                    conOrd++;
                }
                por = coni * 100 / con;
                if(por > mxporc)
                {
                    mxporc = por;
                    ng = x + 1;
                }
            }
            Console.WriteLine("El grupo " + ng + " tiene un mayor porcentaje de numeros impares..");
            Console.WriteLine("Hay " + conOrd + " grupo(s) ordenado(s) de mayor a menor..");
        }
    }
}