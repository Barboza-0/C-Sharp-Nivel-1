using System;

namespace tercer_programa
{
    class Descuentos
    {
        static void Main()
        {
            Console.Write("Ingrese el importe total: "); float itotal = float.Parse(Console.ReadLine());
            float descuento;
            const float descuento1 = 0.10F, descuento2 = 0.18F;
            if(itotal >= 5000){
                descuento = itotal * descuento2;
                itotal -= descuento;
            }else if(itotal >= 1000){
                descuento = itotal * descuento1;
                itotal -= descuento;
            }
            Console.WriteLine("El total a pagar es de " + itotal);
        }
    }
}