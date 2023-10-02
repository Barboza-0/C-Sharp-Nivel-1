using System;

namespace tercer_practica
{
    class PersonalComputer
    {
        static void Main()
        {
            Console.Write("Seleccione un procesador i5(1) i7(2) i9(3): "); int p = int.Parse(Console.ReadLine());
            Console.Write("Seleccione memoria 8RAM(1) 16RAM(2) 32RAM(3): "); int r = int.Parse(Console.ReadLine());
            Console.Write("Ampliar disco duro de 500GB a 1TB SI(1) NO(0): "); int d = int.Parse(Console.ReadLine());
            float total = 0.00F;
            switch(p)
            {
                case 1:
                    switch(r){
                        case 1:
                            total = 800;
                            break;
                        case 2:
                            total = 900;
                            break;
                        case 3:
                            total = 1000;
                            break;
                        default:
                            Console.WriteLine("No ha ingresado una opcion valida..");
                            break;
                    }
                    break;
                case 2:
                    switch(r){
                        case 1:
                            total = 900;
                            break;
                        case 2:
                            total = 1000;
                            break;
                        case 3:
                            total = 1400;
                            break;
                        default:
                            Console.WriteLine("No ha ingresado una opcion valida..");
                            break;
                    }
                    break;
                case 3:
                    switch(r){
                        case 1:
                            total = 1200;
                            break;
                        case 2:
                            total = 1400;
                            break;
                        case 3:
                            total = 2000;
                            break;
                        default:
                            Console.WriteLine("No ha ingresado una opcion valida..");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("No ha ingresado una opcion valida..");
                    break;
            }
            if(d == 1){
                total += 300;
            }
            if(total != 0.00F){
                Console.WriteLine("El monto total es de " + total);
            }
        }
    }
}