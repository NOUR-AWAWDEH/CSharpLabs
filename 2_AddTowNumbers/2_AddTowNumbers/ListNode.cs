using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AddTowNumbers
{
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int value = 0 , ListNode next = null)
        {
            this.Value = value;
            this.Next = null;
        }
    }

}
