namespace LeetCode;

public class AddTwoNumbersTests
{
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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode root = new();
        ListNode current = root;
        bool extra = false;
        while (true)
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + (extra ? 1 : 0);
            extra = sum >= 10;
            current.val = sum % 10;

            l1 = l1?.next;
            l2 = l2?.next;
            if (l1 == null && l2 == null)
                break;

            current.next = new ListNode();
            current = current.next;
        }

        if (extra)
        {
            current.next = new ListNode(1);
            current = current.next;
        }

        return root;
    }

    [Test]
    public void Case1()
    {
        ListNode l1 = new(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new(5, new ListNode(6, new ListNode(4)));
        ListNode result = AddTwoNumbers(l1, l2);
        Assert.AreEqual(7, result.val);
        Assert.AreEqual(0, result.next.val);
        Assert.AreEqual(8, result.next.next.val);
    }

    [Test]
    public void Case2()
    {
        ListNode l1 = new(0);
        ListNode l2 = new(0);
        ListNode result = AddTwoNumbers(l1, l2);
        Assert.AreEqual(0, result.val);
    }

    [Test]
    public void Case3()
    {
        ListNode l1 = new(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        ListNode l2 = new(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        ListNode result = AddTwoNumbers(l1, l2);
        Assert.AreEqual(8, result.val);
        Assert.AreEqual(9, result.next.val);
        Assert.AreEqual(9, result.next.next.val);
        Assert.AreEqual(9, result.next.next.next.val);
        Assert.AreEqual(0, result.next.next.next.next.val);
        Assert.AreEqual(0, result.next.next.next.next.next.val);
        Assert.AreEqual(0, result.next.next.next.next.next.next.val);
        Assert.AreEqual(1, result.next.next.next.next.next.next.next.val);
    }
}