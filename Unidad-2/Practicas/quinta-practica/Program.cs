using System;

namespace quinta_practica
{
    class promedio
    {
        static void Main()
        {
            Console.WriteLine("Ingrese la primer nota: "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: "); int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota: "); int n3 = int.Parse(Console.ReadLine());

            int promedio = (n + n2 + n3) / 3;

            Console.WriteLine("El promedio es de " + promedio);
        }
    }
}