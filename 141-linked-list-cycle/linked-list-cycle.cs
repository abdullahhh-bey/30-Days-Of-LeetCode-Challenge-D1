/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {

        //Mad Approach
        //Going to each node and storing its unique address in a list
        //and if any node contains the already reached address in its next pointer
        //it means it has a cycle

        //List to store the Addresses
        List<ListNode> address = new List<ListNode>();

        if(head == null)
        {
            return false;
        } 

        if(head.next == null)
        {
            return false;
        }

        bool foundCycle = false;
        ListNode current = head;

        address.Add(head);

        while(foundCycle == false)
        {
            if(current.next == null){
                break;
            } else if(address.Contains(current.next))
            {
                return true;
            }else {
                address.Add(current.next);
                current = current.next;
            }
        }

            return false;

    }
}