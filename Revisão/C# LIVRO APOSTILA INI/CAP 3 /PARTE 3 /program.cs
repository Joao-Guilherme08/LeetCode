using Microsoft.VisualBasic;
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
    static void Main()
    {
        //SUBSTRING

        //O método Substring em C# permite extrair uma parte específica de uma string. Ele retorna uma nova string baseada em um índice inicial e, opcionalmente, um comprimento específico.

        //(sintaxe)

        //string novaString = original.Substring(int startIndex);
        //string novaString = original.Substring(int startIndex, int lenght);

        //startIndex: Índice onde a extração começa (baseado em zero).
        //length(opcional): Número de caracteres a serem extraídos.


        //Exemplo 1: Extraindo parte de uma string
        //string texto = "Hello, World!";
        //string resultado = texto.Substring(7); // Começa no índice 7

        //Console.WriteLine(resultado);

        //(Exemplo 2: Extraindo um trecho com comprimento específico)


        //string texto = "C# é uma linguagem poderosa";
        //string resultado = texto.Substring(6, 8); // Começa no índice 6 e pega 8 caracteres

        //Console.WriteLine(resultado);

        //(Exemplo 3: Pegando os 4 últimos caracteres)


        //string texto = "Programação";
        //string ultimosCaracteres = texto.Substring(texto.Length - 4);

        //Console.WriteLine(ultimosCaracteres);
        //texto.Length - 4 indica os últimos 4 caracteres.
        //Output: ção

        //(Exemplo 4: Extraindo o domínio de um e-mail)
        //    Podemos usar Substring junto com IndexOf para obter partes dinâmicas de uma string.

        //string email = "usuario@exemplo.com";
        //int posicaoArroba = email.IndexOf('@');
        //string dominio = email.Substring(posicaoArroba + 1);
        //Console.WriteLine($"dominio: {dominio}" );

        //(Exemplo 5: Pegando um nome de arquivo a partir do caminho)

        string caminho = "C:\\Projetos\\CSharp\\arquivo.txt";
        int indiceUltimaBarra = caminho.LastIndexOf('\\');
        string nomeArquivo = caminho.Substring(indiceUltimaBarra + 1);

        Console.WriteLine($"Nome do arquivo: {nomeArquivo}");

        //        //Resumo sobre Substring
        //✔ Extrai partes específicas de uma string.
        //✔ Pode ser usada com IndexOf e LastIndexOf para manipular strings dinamicamente.
        //✔ Cuidado para não acessar índices fora do tamanho da string.











    }
}
