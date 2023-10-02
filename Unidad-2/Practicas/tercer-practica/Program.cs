using System;

namespace tercer_programa
{
    class tiempo
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la distancia: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad: "); int n2 = int.Parse(Console.ReadLine());

            int resultado = n / n2;

            Console.WriteLine("El resultado es " + resultado.ToString("0.00") + " horas");
        }
    }
}