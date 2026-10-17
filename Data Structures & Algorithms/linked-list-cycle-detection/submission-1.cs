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
    public bool HasCycle(ListNode head) {
        HashSet<int> hash = new HashSet<int>();
        if(head == null)
            return false;
        while(head.next != null)
        {
            if(hash.Contains(head.val))
                return true;
            
            hash.Add(head.val);
            head = head.next;
        }
        
        return false;
    }
}
