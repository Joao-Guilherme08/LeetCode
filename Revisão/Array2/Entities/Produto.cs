using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
