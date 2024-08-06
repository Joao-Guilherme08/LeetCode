using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PrimeiroProjeto
{
    
    
        class Funcionario
        {
            public int Id { get; private set; }
            public string Nome { get; private set; }
            public double Salario { get; private set; }

            public Funcionario(int id, string nome, double salario)
            {
                Id = id;
                Nome = nome;
                Salario = salario;
            }

            public void AumentarSalario(double porcentagem)
            {
                Salario += Salario * (porcentagem / 100.0);
            }

            public override string ToString()
            {
                return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
            }


        }
    }

     
