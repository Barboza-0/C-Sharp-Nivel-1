using System;

namespace primer_practica
{
    class Total
    {
        static void Main()
        {
            int precio, cantidad, resultado;
            Console.Write("Ingrese el precio: "); precio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad: "); cantidad = int.Parse(Console.ReadLine());
            resultado = Producto(precio, cantidad);
            Console.WriteLine("El total es de " + resultado);
        }

        static int Producto(int n1, int n2)
        {
            int resultado;
            resultado = n1 * n2;
            return resultado;
        }
    }
}