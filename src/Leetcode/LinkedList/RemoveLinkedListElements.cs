namespace LeetCode.LinkedList;

public class RemoveLinkedListElements
{
    /// <summary>
    /// Remove all elements of value val in the linked nodes.
    /// </summary>
    /// <param name="head">The head of the linked list.</param>
    /// <param name="val">The value to be removed from the linked list.</param>
    /// <returns></returns>
    public ListNode RemoveElements(ListNode head, int val)
    {
        var sentinel = new ListNode(0);
        sentinel.next = head;
        var curr = sentinel.next;
        var prev = sentinel;
        while (curr is not null)
        {
            if (curr.val == val)
            {
                prev.next = curr.next;
            }
            else
            {
                prev = curr;
            }

            curr = curr.next;
        }

        return sentinel.next;
    }
}