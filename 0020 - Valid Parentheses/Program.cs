namespace _0020___Valid_Parentheses;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite uma string de parênteses: ");
            string entrada = Console.ReadLine() ?? string.Empty;
            bool resultado = ValidarParenteses(entrada);
            Console.WriteLine($"A string é válida? {resultado}");
        }

    }

    static bool ValidarParenteses(string s) 
    {
        if(s.Length % 2 != 0) // Se a string tiver um número ímpar de caracteres, não pode ser válida
            return false; 

        Stack<char> pilha = new();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                pilha.Push(c); // Empilha os parênteses de abertura
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pilha.Count == 0) // Se a pilha estiver vazia, não há parêntese de abertura correspondente
                    return false;
                char topo = pilha.Pop(); // Desempilha o último parêntese de abertura
                if (!VerificarCorrespondencia(topo, c)) // Verifica se os parênteses correspondem
                    return false;
            }
        }

        return pilha.Count == 0; // Se a pilha estiver vazia, todos os parênteses foram correspondidos
    }

    static bool VerificarCorrespondencia(char aberto, char fechado)
    {
        return (aberto == '(' && fechado == ')') ||
               (aberto == '{' && fechado == '}') ||
               (aberto == '[' && fechado == ']');
    }
}
