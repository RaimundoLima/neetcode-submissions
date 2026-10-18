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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 1;
        ListNode first = head;
        if(head.next==null)
            return null;
        while(head != null)
        {
            count++;
            head=head.next;
        }
        head=first;
        count-=n;
        ListNode prev = first;
        if(count <= 1)
            return head?.next;
        while(head != null)
        {
            count--;

            if(count<=0)
            {
                prev.next=head?.next;
                break;
            }
            prev=head;
            head=head.next;
        }
        return first;
    }
}
