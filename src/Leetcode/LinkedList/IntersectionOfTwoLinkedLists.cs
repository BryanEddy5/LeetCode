using System.Collections.Generic;
using LeetCode.Structures;

namespace LeetCode.LinkedList;

public class IntersectionOfTwoLinkedLists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var p1 = headA;
        var p2 = headB;
        while (p1 != p2)
        {
            // p1 and p2 have to be null at some point so the program will exit if there is no intersection.
            p1 = p1 == null ? headB : p1.next;
            p2 = p2 == null ? headA : p2.next;
        }

        return p1;
    }
    
    public ListNode GetIntersectionNodeHash(ListNode headA, ListNode headB)
    {
        var hashSet = new HashSet<ListNode>();
        var pA = headA;
        while (pA is not null)
        {
            hashSet.Add(pA);
            pA = pA.next;
        }

        while (headB is not null)
        {
            if (hashSet.TryGetValue(headB, out var intersection))
            {
                return intersection;
            }

            headB = headB.next;
        }
        
        return null;
    }
}