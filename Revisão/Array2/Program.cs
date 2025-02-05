using System;
using System.Collections.Generic;
using System.Globalization;
using CODE_1.Entities;




namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva quantos produtos serão cadastrados");

            int n = int.Parse(Console.ReadLine());


            Produto[] objetos = new Produto[n];


            for (int i = 0; i < n; i++)
            {
                objetos[i] = new Produto();

                Console.WriteLine("Digite o nome do produto");
                objetos[i].Nome = Console.ReadLine();
                
                Console.WriteLine("Qual o preco do produto");
                objetos[i].Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            double sum = 0.0;
            for(int i = 0; i < n; i++) 
            { 
                sum += objetos[i].Preco;
            }
            double media = sum / n;

            Console.WriteLine("A média dos precos será "  + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
