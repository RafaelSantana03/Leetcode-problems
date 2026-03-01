public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int valorOriginal = x;
        int valorRevertido = 0;

        while (x > 0)
        {
            int ultimoDigito = x % 10;
            valorRevertido = valorRevertido * 10 + ultimoDigito;
            x /= 10;
        }
        if (valorOriginal == valorRevertido)
        {
            return true;
        }
        return false;

    }
}

internal static class Program
{
    private static void Main()
    {
        int teste = 1221;
        var resultado = new Solution().IsPalindrome(teste);
        Console.WriteLine(resultado);
    }
}
