public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        // Dicionário: guarda cada char e o índice onde ele foi visto por último
        var charIndex = new Dictionary<char, int>();

        int left = 0;    // início da janela
        int maxLen = 0;  // maior tamanho encontrado

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            // Se o char já existe E está dentro da janela atual...
            if (charIndex.ContainsKey(c) && charIndex[c] >= left)
            {
                // ...pula o left para logo após a última ocorrência do duplicado
                left = charIndex[c] + 1;
            }

            // Atualiza (ou registra) a posição mais recente do char
            charIndex[c] = right;

            // Tamanho atual da janela = right - left + 1
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}
