A sorted array was rotated at some pivot. Find the minimum element in O(log n). All values are unique.

Input:  [3, 4, 5, 1, 2]
Output: 1

Input:  [4, 5, 6, 7, 0, 1, 2]
Output: 0

public static int Rotate(int[] arr){
		int left = 0;
    int right = arr.Length - 1;
    while (left < right){
    	int mid = left (right - left) / 2;
      
      if (arr[mid] > arr[right]){
      	left = mid + 1;
      }
      else{
      	right = mid;
      }
    }
    return arr[left];    	
}

//Given a sorted array nums and a target, return the index of the target or -1 if it doesn't exist.
//Input:  nums = [-1, 0, 3, 5, 9, 12], target = 9
//Output: 4

public static int findInt(int[] nums, int target) {
		int high = nums.Length - 1;
		int low = 0;
		while (low <= high) {
		    int mid = low + (high - low) / 2;
			if (nums[mid] == target) {
				return mid;
			}
			else if(nums[mid] < target) {
				low = mid + 1;
			}
			else {
				high = mid - 1;
			}
		}
		return -1;
}

//Given a rotated sorted array with unique values and a target, return its index or -1. Must run in O(log n).

//Input:  nums = [4, 5, 6, 7, 0, 1, 2], target = 0
//Output: 4

//Input:  nums = [4, 5, 6, 7, 0, 1, 2], target = 3
//Output: -1

public static int findValueRotated(int[] nums, int target) {
		int left = 0;
		int right = nums.Length - 1;
		while (left <= right) {
			int mid = left + (right - left) / 2;
			if (nums[mid] == target) {
				return mid;
			}
			else if (nums[left] <= nums[mid]) {
				if (nums[left] <= target && target < nums[mid]) {
					right = mid - 1;
				}
				else {
					left = mid + 1;
				}
			}
			else {
				if (nums[mid] < target && target <= nums[right]) {
					left = mid + 1;
				}
				else {
					right = mid - 1;
				}
			}
		}
		return -1;
	}


You are given the root of a binary tree root. Invert the binary tree and return its root.

Example 1:

Input: root = [1,2,3,4,5,6,7]

Output: [1,3,2,7,6,5,4]



/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null){
        	return null;
        }
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        InvertTree(root.left);
        InvertTree(root.rightt);
        return root;
    }
}


L, N, R = In order

N, L, R = Pre order

L, R, N = Post order



Given the root of a binary tree, return its depth.

The depth of a binary tree is defined as the number of nodes along the longest path from the root node down to the farthest leaf node.


Input: root = [1,2,3,null,null,4]

Output: 3


public int FindDepth(TreeNode root) {
	if (root == null){
  	return 0;
  }
  int leftD = FindDepth(root.left);
  int rightD = FindDepth(root.right);
  return 1 + Math.max(leftD, rightD);
}


public class Solution {
    public int MaxDepth(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        if (root != null) {
            q.Enqueue(root);
        }

        int level = 0;
        while (q.Count > 0) {
            int size = q.Count;
            for (int i = 0; i < size; i++) {
                TreeNode node = q.Dequeue();
                if (node.left != null) {
                    q.Enqueue(node.left);
                }
                if (node.right != null) {
                    q.Enqueue(node.right);
                }
            }
            level++;
        }
        return level;
    }
}

Given the roots of two binary trees root and subRoot, 
return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.

A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's descendants. 
The tree tree could also be considered as a subtree of itself.

Example 1:

Input: root = [1,2,3,4,5], subRoot = [2,4,5]

Output: true

public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        
    }
}



public bool subRootInTree(TreeNode root, TreeNode subRoot ) {
	if (root == null){
  	return false;
  }
  if (SameTree(root, subRoot)){
  	return true;
  }
  if (subRootInTree(root.left, subRoot) || subRootInTree(root.right, subRoot)){
  	return true;
  }
  return false;
}

public bool SameTree(TreeNode a, TreeNode b){
	if (a == null & b == null){
  	return true;
  }
  if (a == null || b = null){
  	return false;
  }
  if (a.val != b.val){
  	return false;
  }
  
  if(b.left != null && !SameTree(a.left, b.left)){
  		return false;
  }
  
  if(b.right != null && !SameTree(a.right, b.right)){
      return false;
  }
  
  return true;
}