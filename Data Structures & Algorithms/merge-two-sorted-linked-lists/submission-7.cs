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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var result = new ListNode();
        if(list1 == null && list2 == null)
            return null;
        if(list1 != null && list2 == null)
            return list1;
        if(list2 != null && list1 == null)
            return list2;
        
        if(list1.val<=list2.val){
            result=list1;
            list1 = list1.next;
        }
        else{
            result=list2;
            list2 = list2.next;
        }
        var head = result;
        while(list1 != null || list2 != null)
        {
            Console.WriteLine($"{list1?.val},{list2?.val}");
            if(list1 != null && (list2 == null || list1.val<list2.val))
            {
                result.next = list1;
                result=list1;
                list1=list1.next;
                Console.WriteLine($"if 1");
            }
            else
            {
                result.next = list2;
                result=list2;
                list2=list2.next;
                Console.WriteLine($"if 2");
            }
        }
        return head;
    }
}