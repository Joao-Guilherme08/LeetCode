using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class program
{
    static void Main()
    {
        //SPLIT

        //    separator: O caractere ou string usada para dividir a string original.
        //options: Pode ser StringSplitOptions.RemoveEmptyEntries(remove elementos vazios) ou StringSplitOptions.None(mantém os vazios).

        //string[] resultado = string.Split(char separator);
        //string[] resultado = string.Split(string separator);
        //string[] resultado = string.Split(char[] separators, StringSplitOptions options);



        //Exemplo 1: Separando palavras em uma frase

        //string frase = "C# é uma linguagem poderosa";

        //string[] palavras = frase.Split(' ');//divide pelo espaco

        //Console.WriteLine("Palavras separadas");
        //foreach (string palavra in palavras)
        //{
        //    Console.WriteLine(palavra);
        //}


        //Exemplo 2: Separando um CSV(Comma - Separated Values)

        //string csv = "João,Maria,Carlos,Ana";
        //string[] nomes = csv.Split(','); // Divide pela vírgula

        //Console.WriteLine("Nomes:");
        //foreach (string nome in nomes)
        //{
        //    Console.WriteLine(nome);
        //}


        //Exemplo 3: Usando múltiplos delimitadores

        //Podemos dividir um texto usando mais de um delimitador, como espaços, vírgulas e pontos.

        //string texto = "C# é, sem duvida, uma linguagem poderosa!";

        //char[] delimitadores = { ' ', ',', '.' };

        //string[] palavras = texto.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries);

        //Console.WriteLine("Palavras separadas:");
        //foreach (string palavra in palavras)
        //{
        //    Console.WriteLine(palavra);
        //}

        //Exemplo 4: Extraindo valores de uma data

        //string data = "12/02/2025";
        //string[] partes = data.Split('/');

        //string dia = partes[0];
        //string mes = partes[1];
        //string ano = partes[2];

        //Console.WriteLine($"Dia: {dia}, Mês: {mes}, Ano: {ano}");

        //Exemplo 5: Mantendo elementos vazios

        Se quisermos manter os elementos vazios resultantes da divisão, podemos usar StringSplitOptions.None.

        string texto = "C#,,é,uma,,linguagem,poderosa";
        string[] palavras = texto.Split(',', StringSplitOptions.None);

        Console.WriteLine("Palavras separadas:");
        foreach (string palavra in palavras)
        {
           Console.WriteLine(palavra == "" ? "(vazio)" : palavra);
        }

        //Aqui, os elementos vazios foram mantidos no array.

        //(Resumo sobre Split)

        //        Divide uma string em partes com base em um delimitador.
        //✔ Retorna um array de strings, onde cada elemento é um fragmento do texto original.
        //✔ Pode usar múltiplos delimitadores e remover elementos vazios com StringSplitOptions.RemoveEmptyEntries.
        //✔ Ideal para processar listas, CSVs e textos estruturados.

    }
}
