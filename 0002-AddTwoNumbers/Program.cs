using System;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode cabecaFicticia = new ListNode(0);
        ListNode atual = cabecaFicticia;
        int vaiUm = 0;

        while (l1 != null || l2 != null || vaiUm != 0)
        {
            int soma = vaiUm;
            if (l1 != null)
            {
                soma += l1.val; // Use .val, não .valor
                l1 = l1.next;   // Use .next, não .proximo
            }
            if (l2 != null)
            {
                soma += l2.val;
                l2 = l2.next;
            }

            vaiUm = soma / 10;
            int digito = soma % 10;
            atual.next = new ListNode(digito);
            atual = atual.next;
        }

        return cabecaFicticia.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

internal static class Program
{
    private static void Main()
    {
        // Exemplo de uso: l1 = [2,4,3], l2 = [5,6,4] -> resultado [7,0,8]
        var l1 = Build(new int[] { 2, 4, 3 });
        var l2 = Build(new int[] { 5, 6, 4 });

        var resultado = new Solution().AddTwoNumbers(l1, l2);

        Console.Write("Resultado: ");
        PrintList(resultado);
    }

    private static ListNode Build(int[] digits)
    {
        var cabeca = new ListNode(0);
        var atual = cabeca;
        foreach (var d in digits)
        {
            atual.next = new ListNode(d);
            atual = atual.next;
        }
        return cabeca.next!;
    }

    private static void PrintList(ListNode? node)
    {
        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null) Console.Write(" -> ");
            node = node.next;
        }
        Console.WriteLine();
    }
}