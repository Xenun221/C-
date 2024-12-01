using System;

namespace MyApp
{
    internal class EntradaDeDados2
    {
        static void Main(string[] args)
        {
            //Sempre converter com Parse pois o Console.ReadLine vai enteder que e uma String
            int num1 = int.Parse(Console.ReadLine());
            char sexo = char.Parse(Console.ReadLine());
            double n2= double.Parse(Console.ReadLine());

            //USANDO O SPLIT
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            double n0 = double.Parse(vet[4]);

            //Ler os dados
            Console.WriteLine("Vode Digitou: ");
            Console.WriteLine(num1);
            Console.WriteLine(sexo);
            Console.WriteLine(n2);

            //Na mesma linha usando o split
            Console.WriteLine(altura);  
            Console.WriteLine(nome);  
            Console.WriteLine(idade);
            Console.WriteLine(n0);
           
        }
    }
}