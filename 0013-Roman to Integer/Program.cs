
var valor = "LVIII";
var resultado = new Solution().RomanToInt(valor);
Console.WriteLine(resultado);


public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int currentValue = romanMap[s[i]];
            int nextValue = (i + 1 < s.Length) ? romanMap[s[i + 1]] : 0;
            if (currentValue < nextValue)
            {
                total -= currentValue; // Subtrair se o valor atual for menor que o próximo
            }
            else
            {
                total += currentValue; // Adicionar caso contrário
            }
        }
        return total;
    }
}
