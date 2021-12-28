using LeetCode.Structures;

namespace LeetCode.LinkedList;

public class MyLinkedList
{
    private SinglyListNode _head;

    private int _count;
    
    public int Get(int index)
    {
        return GetNode(index)?.val ?? -1;
    }

    public void AddAtHead(int val)
    {
        var newHead = new SinglyListNode(val)
        {
            next = _head
        };
        _head = newHead;
        _count++;
    }

    public void AddAtTail(int val)
    {
        if (_count == 0)
        {
            AddAtHead(val);
            return;
        }

        var prev = _head;
        while (prev.next is not null)
        {
            prev = prev.next;
        }

        prev.next = new SinglyListNode(val);
        _count++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > _count)
        {
            return;
        }

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        var node = GetNode(index - 1);
        var next = node.next;
        node.next = new SinglyListNode(val)
        {
            next = next
        };
        _count++;
    }

    public void DeleteAtIndex(int index)
    {
        if (index >= _count || _count == 0) return;
        if (index == 0)
        {
            _head = _head.next;
        }
        else
        {
            var node = GetNode(index - 1);
            node.next = node?.next?.next;
        }

        _count--;
    }

    internal SinglyListNode GetNode(int index)
    {
        if (_count == 0) return null;
        var node = _head;
        var next = node.next;
        for (var i = 0; i < index; i++)
        {
            node = next;
            next = node?.next;
        }

        return node;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */