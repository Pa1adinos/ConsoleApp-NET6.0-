using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_NET6._0_
{
    internal class AddTwoNumbers
    {
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
        public static void Start()
        {
            //int[] l1 = { 2, 4, 3 }, l2 = { 5, 6, 4 };
            ListNode l1 = new ListNode();
            ListNode l2 = new ListNode();
            l1.val = 2;
            l1.val = 4;
            l1.val = 3;

            l2.val = 5;
            l2.val = 6;
            l2.val = 4;
/*
            ListNode result = new ListNode();

            string num1 = "", num2 = "";
            foreach (int i in l1)
            {
                num1 = Convert.ToString(i) + num1;
            }
            foreach (int i in l2)
            {
                num2 = Convert.ToString(i) + num2;
            }
            int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
            Console.WriteLine(sum);
            string summ = Convert.ToString(sum);*/
        }
    }
}
