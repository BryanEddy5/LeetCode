namespace LeetCode.LinkedList;

public class RemoveNthNodeFromTheEnd
{
    /// <summary>
    /// Remove the nth node form the end of the linked list.
    /// </summary>
    /// <param name="head"></param>
    /// <param name="n">The node to be removed.</param>
    /// <returns></returns>
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // The sentinel helps remove some edge cases when the 
        // node to be removed is the head.
        var sentinel = new ListNode(0);
        sentinel.next = head;
        
        // Move n+1 positions 
        var leader = sentinel;
        for (var i = 0; i <= n; i++)
        {
            leader = leader.next;
        }

        // 
        var follower = sentinel;
        // when the leader reaches the end (null) then the follower will be 
        // be at nth-1 position.
        while (leader is not null)
        {
            follower = follower.next;
            leader = leader.next;
        }

        follower.next = follower?.next?.next;
        return sentinel.next;
    }
}

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