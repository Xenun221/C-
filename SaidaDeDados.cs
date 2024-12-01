using System;
using System.Globalization;

namespace MyApp
{
    internal class SaidaDeDados
    {
        static void Main(string[] args)
        {


            /*Com quebra de linha */
            Console.WriteLine("Ola Mundo!");

            /*Sem quebra de linha:  */
            Console.Write("Olá Amigo! ");
            Console.Write("Oi Mundo!");

            /*Para ler numeros com ponto flutuantes*/
            double x = 10.35784;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));


            /*Para concatenar vários elementos*/
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor de troco é " + x.ToString("F2") + " reais");

            Console.ReadLine();

        }
    }
}