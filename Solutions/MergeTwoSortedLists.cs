using System;

namespace CSharp.Solutions
{
    public class MergeLists
    {
        
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // create a linkedlist l3
            // index through l1
            // index through l2
            // compare pointer l1 to pointer l2
            // add lower value to l3
            var cursorL1 = l1;
            var cursorL2 = l2;
            var listNodeHead = new ListNode();
            var runnerHead = listNodeHead;
            while (cursorL1 != null &&  cursorL2 != null)
            {
                System.Console.WriteLine($"runnerhead = {runnerHead.val}");
                System.Console.WriteLine($"listNodeHead = {listNodeHead.val}");
                if (cursorL1.val <= cursorL2.val)
                {
                    runnerHead.next = cursorL1;
                    cursorL1 = cursorL1.next;
                }
                else
                {
                    runnerHead.next = cursorL2;
                    cursorL2 = cursorL2.next;
                }
                runnerHead = runnerHead.next;
            }
            return listNodeHead.next;
        }
        
    }

    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }
}