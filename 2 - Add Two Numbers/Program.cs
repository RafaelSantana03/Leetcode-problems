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
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}