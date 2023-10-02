using System;

namespace tercer_practica
{
    class VeinteNros
    {
        static void Main()
        {
            int contador = 0, acumulador = 0, promedio = 0;
            for(int x = 0; x < 20; x++)
            {
            Console.Write("Ingrese un numero: "); int n = int.Parse(Console.ReadLine());
            if(n >= 18)
            {
                contador++;
                acumulador += n;
            }
            }
            promedio = acumulador / contador;
            Console.WriteLine("El promedio de mayores de edad es de " + promedio);
        }
    }
}