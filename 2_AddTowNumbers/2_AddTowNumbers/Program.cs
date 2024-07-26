using _2_AddTowNumbers;
public class Program
{
    public static void Main(string[] args)
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        SolutionBase solution = new SolutionBase();
        ListNode result = solution.AddTwoNumbers(l1, l2);

        PrintList(result); // Output: 7 -> 0 -> 8
    }

    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.Value + " -> ");
            node = node.Next;
        }
        Console.WriteLine("null");
    }
}