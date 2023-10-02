using System;

namespace cuarta_practica
{
    class Sueldo
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el total facturado: "); float total = float.Parse(Console.ReadLine());
            float descuento = total * 0.05F;

            float resultado = 15000 + descuento;

            Console.WriteLine("El sueldo total es " + resultado);
        }
    }
}