using System;

namespace MyApp
{
    internal class EntradaDeDados
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite oq vc desje: ");
            string frase = Console.ReadLine();
    
            //Entrada de Dados
            string x = Console.ReadLine();
            string y = Console.ReadLine(); 
            string z = Console.ReadLine();

            //Usando VETORES
            string s = Console.ReadLine();
            string[] v = s.Split(' '); // string[] v = Console.ReadLine().Split(' '); posso fz dessa forma sem o string s no começo
            string a = v[0];
            string b = v[1];
            string c = v[2];



            //Saida de Dados
            Console.WriteLine("Voce Digitou:  ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}