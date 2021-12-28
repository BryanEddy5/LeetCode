using LeetCode.LinkedList;
using Xunit;

namespace LeetCodeTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1,2);
        Assert.Equal(2,myLinkedList.Get(1));
        myLinkedList.DeleteAtIndex(1);
        Assert.Equal(3,myLinkedList.Get(1));
    }
    
    [Fact]
    public void Test2()
    {
        var myLinkedList = new MyLinkedList();
        myLinkedList.AddAtHead(1);
        myLinkedList.AddAtTail(3);
        myLinkedList.AddAtIndex(1,2);
        Assert.Equal(2,myLinkedList.Get(1));
        myLinkedList.DeleteAtIndex(0);
        Assert.Equal(2,myLinkedList.Get(0));
    }
    
    [Fact]
    public void Test3()
    {
        var myLinkedList = new MyLinkedList();
        myLinkedList.AddAtIndex(0,10);
        myLinkedList.AddAtIndex(0,20);
        myLinkedList.AddAtIndex(1,30);
        Assert.Equal(20,myLinkedList.Get(0));
    }
}