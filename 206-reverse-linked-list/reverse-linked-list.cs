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
        ListNode temp = head;
        ListNode current = head;
        ListNode forward = null;

        if( head == null)
        {
            return null;
        }
        
        if(head.next == null )
        {
            return head;
        }

        while(current != null)
        {
            temp = current.next;
            current.next = forward;
            forward = current;
            current = temp; 
        }

       
            return forward;
        

    }
}