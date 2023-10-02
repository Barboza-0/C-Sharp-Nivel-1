using System;

namespace segunda_practica
{
    class Descuento
    {
        static void Main()
        {
            Console.Write("Ingrese el importe total: "); float itotal = float.Parse(Console.ReadLine());
            Console.Write("Ingrese los litros comprados: "); int litros = int.Parse(Console.ReadLine());
            float total = itotal;
            if(litros > 500){
                total = itotal * 0.75F;
            }else if(litros > 300){
                total = itotal * 0.85F;
            }else if(litros > 100){
                total = itotal * 0.90F;
            }
            Console.WriteLine("El total a pagar es de " + total);
        }
    }
}