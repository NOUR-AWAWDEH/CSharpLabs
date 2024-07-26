using _2_AddTowNumbers;

public class SolutionBase
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode p = l1, q = l2, current = dummyHead;
        int carry = 0;

        while (p != null || q != null)
        {
            int x = (p != null) ? p.Value : 0;
            int y = (q != null) ? q.Value : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            current.Next = new ListNode(sum % 10);
            current = current.Next;
            if (p != null) p = p.Next;
            if (q != null) q = q.Next;
        }

        if (carry > 0)
        {
            current.Next = new ListNode(carry);
        }

        return dummyHead.Next;
    }
}