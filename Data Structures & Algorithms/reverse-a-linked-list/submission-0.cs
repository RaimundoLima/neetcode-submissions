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
        ListNode actual = head;
        ListNode prev = null;
        while(actual != null)
        {
            var next = actual.next;
            actual.next = prev;
            prev = actual;
            actual = next;
        }
        return prev;
    }
}
