using System;
using System.Collections.Generic;
using System.Globalization;

namespace CODE_1.Entities
{
    public class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }

        public Produto(double preco, string nome)
        {
            Preco = preco;
            Nome = nome;
        }

        public Produto() { }

        public static double CalcularMediaPrecos(Produto[] produtos)
        {
            double sum = 0.0;
            for (int i = 0; i < produtos.Length; i++)
            {
                sum += produtos[i].Preco;
            }
            return sum / produtos.Length;
        }
    }
}
