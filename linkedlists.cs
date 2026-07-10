LinkedList

Given the beginning of a singly linked list head, reverse the list, and return the new beginning of the list.

Input: head = [0,1,2,3]

Output: [3,2,1,0]


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
    		ListNode prev = null;
        ListNode curr = head;
        
        while (curr != null){
        	ListNode next = curr.next;
          curr.next = prev;
          prev = curr;
          curr = next;
        }
        return prev;
    }
    		
    
Merge Two Sorted Linked Lists

You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted linked list and return the head of the new sorted linked list.

The new list should be made up of nodes from list1 and list2.


Input: list1 = [1,2,4], list2 = [1,3,5]

Output: [1,1,2,3,4,5]    
    
    
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
        ListNode head = null;
        
        if (list1 == null){
        	return list2;
        }        		
        if (list2 == null){
        	return list1;
        }
        
        if (list1.val <= list2.val){
        	head = list1; 
          list1 = list1.next;
        }
        else{
        	head = list2;
          list2 = list2.next;
        }
        
        ListNode curr = head;
        while (list1 != null && list2 != null){
        	if (list1.val <= list2.val){
          	curr.next = list1;
            list1 = list1.next;
          }
          else{
          	curr.next = list2;
            list2 = list2.next;
          }
          curr = curr.next;
        }
        if (list1 != null){
        	curr.next = list1;
        }
        else{
        	curr.next = list2;
        }
        
        return head;
    }
}    
    
    
//Printing linkedlist


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode printLinkdList(ListNode head) {
    		ListNode curr = head;
        while (curr != null){
        		Console.Writeline(curr.val);
            curr = curr.next;
        }
    }
}
    
    
1 -> 2 -> 3 -> 4   

ListNode one = new ListNode(1);
one.next = two;
ListNode two = new ListNode(2);
two.next = three;
ListNode three = new ListNode(3);
three.next = four;
ListNode four = new ListNode(4);
four.next = null;

ListNode head = one;

ListNode curr = head;

}



public ListNode createLikedListFromList(List<int> allInts){
		ListNode head = new ListNode(allInts[0]);
    
    ListNode curNode = head;
    for(int i = 1; i < allInts.Length; i++){
    	curNode.next = new ListNode(allInts[i]);
      curNode = curNode.next;
    }
    return head;
}

    
////////////////////////



using System;

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

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}

class Program
{
    static void Main()
    {
        // Create: 0 -> 1 -> 2 -> 3
        ListNode head = new ListNode(0);
        head.next = new ListNode(1);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(3);

        Solution solution = new Solution();

        ListNode reversed = solution.ReverseList(head);

        PrintList(reversed);
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val);

            if (head.next != null)
                Console.Write(" -> ");

            head = head.next;
        }

        Console.WriteLine();
    }
}
    
    
  
  
  







///////////////////////





using System;
using System.Collections.Generic;

class HelloWorld
{
    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 5, 6 };
        List<int> list2 = new List<int> { 1, 2, 3, 4 };

        ListNode lst1 = CreateLinkedListFromList(list1);
        ListNode lst2 = CreateLinkedListFromList(list2);

        PrintLinkedList(MergeTwoLists(lst1, lst2));
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

    public static ListNode CreateLinkedListFromList(List<int> allInts)
    {
        if (allInts.Count == 0)
        {
            return null;
        }

        ListNode head = new ListNode(allInts[0]);
        ListNode curNode = head;

        for (int i = 1; i < allInts.Count; i++)
        {
            curNode.next = new ListNode(allInts[i]);
            curNode = curNode.next;
        }

        return head;
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode head;

        if (list1.val <= list2.val)
        {
            head = list1;
            list1 = list1.next;
        }
        else
        {
            head = list2;
            list2 = list2.next;
        }

        ListNode curr = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                list2 = list2.next;
            }

            curr = curr.next;
        }

        if (list1 != null)
        {
            curr.next = list1;
        }
        else
        {
            curr.next = list2;
        }

        return head;
    }

    public static void PrintLinkedList(ListNode head)
    {
        ListNode curr = head;

        while (curr != null)
        {
            Console.WriteLine(curr.val);
            curr = curr.next;
        }
    }
}
    
    
    
You are given the head of a singly linked-list.

The positions of a linked list of length = 7 for example, can intially be represented as:

[0, 1, 2, 3, 4, 5, 6]

Reorder the nodes of the linked list to be in the following order:

[0, 6, 1, 5, 2, 4, 3]

Notice that in the general case for a list of length = n the nodes are reordered to be in the following order:

[0, n-1, 1, n-2, 2, n-3, ...]

You may not modify the values in the list's nodes, but instead you must reorder the nodes themselves.

Example 1:

Input: head = [2,4,6,8]

Output: [2,8,4,6]
Example 2:

Input: head = [2,4,6,8,10]

Output: [2,10,4,8,6]
Constraints:

1 <= Length of the list <= 1000.
1 <= Node.val <= 1000
    
using System;
using System.Collections.Generic;
    
class HelloWorld
{
    static void Main()
    {
    
    
    }
    
        public void ReorderList(ListNode head) {
    		ListNode curr1 = head;
        int len = 0;
        List<int> nums = new List<int>();
        while (curr1 != null){
        		len += 1;
            nums.Add(curr1.val);
        		curr1 = curr1.next;
        }
        
        ListNode curr2 = head;
        ListNode curr3 = head;
        for (int i = 0; i < len; i++){
        		int n = 0;
        		if (i % 2 == 0){
            		n = len - i;
                while (curr2.val != nums[n]){
                		curr2 = curr2.next;
                }
              	curr3.next = curr2;
              	curr3 = curr3.next;  
            }
            curr3 = curr3.next;
        }
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
    

    
    public static void PrintLinkedList(ListNode head)
    {
        ListNode curr = head;

        while (curr != null)
        {
            Console.Write(curr.val);
            curr = curr.next;
        }
    }

}
    
    
    
 public class Solution {
    public void ReorderList(ListNode head) {
    		ListNode curr1 = head;
        int len = 0;
        List<int> nums = new List<int>();
        while (curr1 != null){
        		len += 1;
            nums.Add(curr1.val);
        		curr1 = curr1.next;
        }
        
        ListNode curr2 = head;
        ListNode curr3 = head;
        for (int i = 0; i < len; i++){
        		int n = 0;
        		if (i % 2 == 0){
            		n = len - i;
                while (curr2.val != nums[n]){
                		curr2 = curr2.next;
                }
              	curr3.next = curr2;
              	curr3 = curr3.next;  
            }
            curr3 = curr3.next;
        }
    }
  }   
[0, 1, 2, 3, 4, 5, 6]

[0, 6, 1, 5, 2, 4, 3]  
    
    
   if(head != null && head.next != null){
            int size = 0;
            ListNode curNode = head;
            while(curNode != null){
            		size += 1;
                curNode = curNode.next;
            }
            
            ListNode[] nodes = new ListNode[size];
            int i = 0;
            curNode = head;
            while(curNode != null){
                nodes[i] = curNode;
                i++;
                curNode = curNode.next;
            }

            int left = 0;
            int right = size-1;

            while(left < right){
                nodes[left].next = nodes[right];
                nodes[right].next = nodes[left+1];
                left++;
                right--;
            }
            nodes[left].next = null; // why do we need this??
        }  
    
 [0, 1, 2, 3, 4, 5, 6]

[0, 6, 1, 5, 2, 4, 3]  
     
    
    
Given the beginning of a linked list head, return true if there is a cycle in the linked list. Otherwise, return false.

There is a cycle in a linked list if at least one node in the list can be visited again by following the next pointer.

Internally, index determines the index of the beginning of the cycle, if it exists. The tail node of the list will set it's next pointer to the index-th node. 
If index = -1, then the tail node points to null and no cycle exists.

Note: index is not given to you as a parameter.

    
    
   
  
  
  
public class Solution {
    public bool HasCycle(ListNode head) {
    		HashSet<ListNode> visited = new HashSet<ListNode>();
        ListNode curr = head;
        
        while (curr != null){
        		if (visited.Contains(curr)){
            		return true;
            }
            
            visited.Add(curr);
            curr = curr.next;
        }
        return false;
        
    }
				
}


public class Solution {
    public bool HasCycle(ListNode head) {
   			ListNode slow = head;
        ListNode fast = head;
        
        while (fast != null && fast.next != null){
        		slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast){
            		return true;
            }
        }
        return false;
        
  	}
}

using System;
using System.Collections.Generic;

class HelloWorld {
	static void Main() {
		List<int> nums = new List<int> {1, 2, 3, 4};
		ListNode lst = CreateCyclicLinkedListFromList(nums);
		Console.WriteLine(HasCycle(lst));
		
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

	public static ListNode CreateCyclicLinkedListFromList(List<int> allInts)
	{
		if (allInts.Count == 0)
		{
			return null;
		}

		ListNode head = new ListNode(allInts[0]);
		ListNode curNode = head;

		for (int i = 1; i < allInts.Count; i++)
		{
			curNode.next = new ListNode(allInts[i]);
			curNode = curNode.next;
		}

		//curNode.next = head.next;

		return head;
	}

	public static void PrintLinkedList(ListNode head)
	{
		ListNode curr = head;

		while (curr != null)
		{
			Console.Write(curr.val);
			curr = curr.next;
		}
	}

	public static bool HasCycle(ListNode head) {
		ListNode slow = head;
		ListNode fast = head;

		while (fast != null && fast.next != null) {
			slow = slow.next;
			fast = fast.next.next;

			if (slow == fast) {
				return true;
			}
		}
		return false;

	}

}
