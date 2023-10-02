using System;

namespace tercer_practica
{
    class Reemplazo
    {
        static void Main()
        {
            char[] frase = new char[31];
            char letra, letraUno, letraDos;
            int con = 0;
            Console.Write("Ingrese una frase.. (Letra por letra) "); letra = char.Parse(Console.ReadLine());
            while(letra != '.' && con < 30)
            {
                frase[con] = letra;
                con++;
                Console.Write("Ingrese una frase.. (Letra por letra) "); letra = char.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese la letra que desea reemplazar: "); letraUno = char.Parse(Console.ReadLine());
            Console.Write("reemplazará '" + letraUno + "' por: "); letraDos = char.Parse(Console.ReadLine());
            for(int x = 0; x < 30; x++)
            {
                if(frase[x] == letraUno)
                {
                    frase[x] = letraDos;
                }
                if(frase[x] == '\0')
                {
                    break;
                }
                Console.Write(frase[x]);
            }
        }
    }
}
//String
//frase = frase.Replace(a, o);