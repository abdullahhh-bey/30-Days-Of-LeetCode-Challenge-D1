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

        // //Mad Approach
        // //Going to each node and storing its unique address in a list
        // //and if any node contains the already reached address in its next pointer
        // //it means it has a cycle

        // //List to store the Addresses
        // List<ListNode> address = new List<ListNode>();

        // //Checks for validation
        // if(head == null)
        // {
        //     return false;
        // } 

        // //For Strarting while loop
        // bool foundCycle = false;
        // //POinter that points to the head ad then used for traversal
        // ListNode current = head;

        // //Adding the address of the very first node ( head )
        // address.Add(head);

        // //Main Logic
        // while(foundCycle == false)
        // {
        //     if(current.next == null ){
        //         break;
        //     } else if(address.Contains(current.next))
        //     {
        //         return true;
        //     }else {
        //         address.Add(current.next);
        //         current = current.next;
        //     }
        // }

        // //If no cycle is found, return false
        //     return false;


        //Floyd Tortuse&Rabbit Approach
        //Making a fast pointer ahead of the slow pointer
        //If fast pointer meets slow pointer at some pointer. it means there is a cycle, hence 
        //return true
        
        if(head == null || head.next == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head.next;

        //It there is no cycle, this condition will become false in upcoming iterations
        while(fast != null && fast.next != null)
        {
            //If equals, then it means there is a cycle
            if(fast == slow)
            {
                return true;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return false;

    }
}