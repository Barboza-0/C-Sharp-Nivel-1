using System;

namespace primer_ejemplo
{
    class Vectores
    {
        static void Main()
        {
            string nombre;
            Console.Write("Ingrese su nombre: "); nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}

//VECTORES INT                                              INT INT 

//using System;

//namespace primer_ejemplo
//{
    //class Vectores
    //{
        //static void Main()
        //{
            //int[] numeros = new int[10];

            //for(int x = 0; x < 10; x++)
            //{
                //numeros[x] = x + 1;
            //}
            //for(int x = 0; x < 10; x++)
            //{
                //Console.WriteLine(numeros[x]);
            //}
        //}
    //}
//}

//VECTORES DOUBLE                                       DOUBLE  DOUBLE  

//using System;

//namespace primer_ejemplo
//{
    //class Vectores
    //{
        //static void Main()
        //{
            //double[] casilla = new double[3];
            //double n, acu = 0;

            //for(int x = 0; x < 3; x++)
            //{
                //Console.Write("Ingrese los registros: "); n = double.Parse(Console.ReadLine());
                //casilla[x] = n;
            //}
            //for(int x = 0; x < 3; x++)
            //{
                //acu += casilla[x];
            //}
            //acu = acu / 3;
            //Console.WriteLine(acu);
        //}
    //}
//}

//VECTORES BOOLEANOS                                     BOOL    BOOL

//using System;

//namespace primer_ejemplo
//{
    //class Vectores
    //{
        //static void Main()
        //{
            //bool[] verdaderos = new bool[5];
            //bool n;

            //for(int x = 0; x < 5; x++)
            //{
                //Console.Write("Ingrese true/SI false/NO: "); n = bool.Parse(Console.ReadLine());
                //verdaderos[x] = n;
            //}
            //for(int x = 0; x < 5; x++)
            //{
                //Console.WriteLine(verdaderos[x]);
            //}
        //}
    //}
//}

//VECTORES CHAR                                        CHAR    CHAR

//using System;

//namespace primer_ejemplo
//{
    //class Vectores
    //{
        //static void Main()
        //{
            //char[] frase = new char[12];
            //char letra;
            //int contador = 0;
            //Console.Write("Ingrese su nombre letra por letra y un punto al final: "); letra = char.Parse(Console.ReadLine());
            //while(letra != '.' && contador < 11)
            //{
                //frase[contador] = letra;
                //contador++;
                //Console.Write("Ingrese su nombre letra por letra y un punto al final: "); letra = char.Parse(Console.ReadLine());
            //}
            //contador = 0;
            //Console.Write("Hola ");
            //while(frase[contador] != '\0')
            //{
                //Console.Write(frase[contador]);
                //contador++;
            //}
        //}
    //}
//}