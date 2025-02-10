namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // METODO TRIM

            //string texto = "  Olá, mundo!  ";
            //string resultado = texto.Trim();

            // Console.WriteLine($"Texto Original: '{texto}' ");
            //Console.WriteLine($"Texto Original: '{resultado}' ");

            // --------------------------------------------------//

            //outros Exemplos de metodos TrimStart() e TrimEnd()

            //string resultado = texto.TrimStart();
            //string resultado2 = texto.TrimEnd();

            //Console.WriteLine($"Texto Original: '{resultado}' ");
            //Console.WriteLine($"Texto Original: '{resultado2}' ");

            //OU DESSA OUTRA FORMA

            //Console.WriteLine($"Texto Original: '{texto.TrimStart()}' ");
            //Console.WriteLine($"Texto Original: '{texto.TrimEnd()}' ");

            //-----------------------------------------------//

            // PROPRIEDADE - Length 

            //string texto = "Olá, mundo!";
            //Console.WriteLine($"A string '{texto}' tem {texto.Length} caracteres. ");

            //-----------------------------------------------//

            // METODO - ToUpper    ATALHO - CRTL + K + C

            //string texto = "Olá, mundo!";
            //string textoMaiusculo = texto.ToUpper();

            //Console.WriteLine($"Texto original: {texto} ");
            //Console.WriteLine($"Texto em maiusculas: {textoMaiusculo}");

            //Exemplo 2: Comparando strings de forma case-insensitive

            //string senhaUsuario = "Segredo123";
            //string senhaDigitada = "SEGREDO123";

            //bool iguais = senhaUsuario.ToUpper() == senhaDigitada.ToUpper();

            //Console.WriteLine($"As senhas são iguais : {iguais}");

            ////Exemplo 3:  O método ToUpper não altera a string original, pois strings em C# são imutáveis. Ele retorna uma nova string com os caracteres modificados.
            //O comportamento do ToUpper depende da cultura padrão do sistema.Para evitar problemas com culturas diferentes(como turco), é possível usar a versão que aceita CultureInfo.

            //string texto = "merhaba"; //Olá em turco
            //string textoMaiusculo = texto.ToUpper(CultureInfo.InvariantCulture);
            //Console.WriteLine($"Texto em maiúsculas (cultura invariável): {textoMaiusculo}");
            //Console.WriteLine($"Texto normal : {texto}");


            //----------------------------------------------//

            //Método ToLower()

            //string texto = "Olá, mundo!";
            //string textoMinusculo = texto.ToLower();

            //Console.WriteLine($"Texto original:  {texto}");
            // Console.WriteLine($"Texto Minusculo: {textoMinusculo}");

            //(EXEMPLO 3 ) Ao trabalhar com endereços de e-mail, uma boa prática é sempre armazená-los em letras minúsculas para evitar inconsistências.

            //string email = "Usuario@Dominio.com";
            //string emailNormalizado = email.ToLower();

            //Console.WriteLine($"E-mail original: {email}");
            //Console.WriteLine($"E-mail normalizado: {emailNormalizado}");

            //Assim como o ToUpper, o método ToLower também é influenciado pela cultura do sistema. Caso você precise garantir uma conversão consistente entre diferentes culturas, use CultureInfo.InvariantCulture.

            //---------------------------------------------------------------//



            //  --------------------------------------------------------

            // MÉTODO REMOVE : O método Remove em C# é usado para remover uma parte da string, a partir de um índice específico. Ele pode ser usado para excluir caracteres indesejados de um texto.

            // string.Remove(int startIndex);
            //string.Remove(int startIndex, int count);
            //Remove todos os caracteres da string a partir do índice informado.
            //startIndex: Índice a partir do qual a remoção começa.
            //count(opcional): Número de caracteres a serem removidos. Se não for especificado, remove do startIndex até o final da string.

            //EXEMPLO 1: REMOVENDO CARACTERES A PARTIR DE UM INDICE

            //string texto = "Programacao em C#";  //EM C# É REMOVIDO
            //string novoTexto = texto.Remove(12);

            //Exemplo 2: Removendo uma quantidade específica de caracteres

            //string texto = "Aprender c# é divertido!";
            //string novoTexto = texto.Remove(9, 3);

            //Console.WriteLine($"Texto original: {texto}");
            //Console.WriteLine($"Texto após Remove(9,3): {novoTexto}");

            //Exemplo 3: Removendo a última palavra de uma frase

            //string frase = "Eu gosto de café";
            //int indiceEspaco = frase.LastIndexOf(" "); // Encontra o último espaço

            //string novaFrase = frase.Remove(indiceEspaco);

            //Console.WriteLine($"Frase original: {frase}");
            //Console.WriteLine($"Frase após remoção da última palavra: {novaFrase}");

            //-----------------------------------------------------------------------------//

            //MÉTODO REPLACE 

            //SINTAXE:
            //string.Replace(char oldChar, char newChar);
            //string.Replace(string oldValue, string newValue);
            //oldChar / oldValue: O caractere ou texto que será substituído.
            // newChar / newValue: O caractere ou texto pelo qual será substituído.

            //Exemplo 1: Substituindo caracteres individuais

            //string texto = "1,5 -  2,7 - 3,9";
            //string novoTexto = texto.Replace(",", ".");
            //Console.WriteLine($"Texto original: {texto}");
            //Console.WriteLine($"Texto após Replace(',', '.'): {novoTexto}");
            // Aqui, todas as vírgulas foram substituídas por pontos.

            //Exemplo 2: Substituindo palavras dentro de um texto
            //string mensagem = "Bom dia, João!";
            //string novaMensagem = mensagem.Replace("João", "Maria");

            //Console.WriteLine($"Mensagem original: {mensagem}");
            //console.WriteLine($"Mensagem modificada: {novaMensagem}");

            //Exemplo 3: Removendo espaços extras de uma frase

            //string frase = "C#  é  uma  linguagem  poderosa!";
            //string fraseCorrigida = frase.Replace("  ", " "); // Troca espaços duplos por simples

            //Console.WriteLine($"Frase original: {frase}");
            //Console.WriteLine($"Frase corrigida: {fraseCorrigida}");

            //Exemplo 4: Formatando números de telefone
            string telefone = "(81) 98765-4321";
            string telefoneFormatado = telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            Console.WriteLine($"Número original: {telefone}");
            Console.WriteLine($"Número formatado: {telefoneFormatado}");

            // Aqui, parênteses, hífens e espaços foram removidos para deixar o número somente com dígitos.

            //Observações:
            //✔️ O método Replace não altera a string original, pois strings em C# são imutáveis. Ele retorna uma nova string com a substituição.
            //✔️ Se a string não contiver o valor a ser substituído, o método retorna a string original sem alterações.
            //✔️ O Replace é sensível a maiúsculas e minúsculas, ou seja, "Casa" é diferente de "casa".


        }
    }
}


