
public class Solution {
    public int RomanToInt(string s) {
        var RomanToInt = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        s = s.ToUpper(); // Converte a string para maiúsculas (pode ser feito antes de converter em char array)
        var result = 0;

        for (int index = 0; index < s.Length; index++)
        {
            // Obtém o valor inteiro do caractere romano atual
            var current = RomanToInt[s[index]];

            // Verifica se é o último caractere da string
            if (index == s.Length - 1)
            {
                result += current; // Adiciona o valor do último caractere ao resultado final
            }
            else
            {
                // Obtém o valor inteiro do próximo caractere romano
                var next = RomanToInt[s[index + 1]];

                // Compara os valores atuais e próximos para determinar adição ou subtração
                if (current < next)
                {
                    result -= current; // Subtrai se o valor atual for menor que o próximo
                }
                else
                {
                    result += current; // Adiciona se o valor atual for maior ou igual ao próximo
                }
            }
        }

        return result;
    }
}
