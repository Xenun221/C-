using System;

namespace MyApp
{
    internal class ProcessamentoDeDados
    {
        static void Main(string[] args)
        {
            int x, y;

            x = 5;

            y = 2 * x;

            
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.ReadLine();

            /*Calcular Base do trapezio*/
            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);
            Console.ReadLine();

            //Calculando nota
            int c, d;
            double resultado;

            c = 5;
            d = 2;

            resultado = c / d;
            Console.WriteLine(resultado);
            Console.ReadLine();


            //CASTING
            int g, i;

            double res;
            g = 5;
            i = 2;

            res = (double)g / i;
            Console.WriteLine(res);

           
        }
    }
}