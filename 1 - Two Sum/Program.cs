public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //Dicionario para mapear valor e o indice
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            // Calcular o complemento necessário para atingir o alvo
            int complement = target - nums[i];
            // Verificar se o complemento já está no dicionário
            if (numToIndex.ContainsKey(complement))
            {
                // Se encontrado, retornar os índices
                return new int[] { numToIndex[complement], i };
            }
            // Caso contrário, adicionar o número atual e seu índice ao dicionário
            numToIndex[nums[i]] = i;
        }

        throw new ArgumentException("Nenhuma solução encontrada");
    }
}