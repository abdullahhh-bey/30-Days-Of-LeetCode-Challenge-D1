/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {

        //Defining 3 pointers 
        //temp for next 
        //current for iteration
        //forwatrd for the previous
        ListNode temp = head;
        ListNode current = head;
        ListNode forward = null;

        //Chevcking  if its null or not
        if( head == null)
        {
            return null;
        }

        if(head.next == null )
        {
            return head;
        }

        //This is the main logic and its very simple
        //I used two pointer approach to solvethis 
        while(current != null)
        {
            temp = current.next;
            current.next = forward;
            forward = current;
            current = temp; 
        }

            //returning the head of the new reverse linked list 
            return forward;
        

    }
}