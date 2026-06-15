
// Given an array nums, return a new array where each element is the sum of all previous elements including itself.
// Input:  [1, 2, 3, 4]
// Output: [1, 3, 6, 10]

using System;
class HelloWorld {
	static void Main() {
		int[] arr = [1, 2, 3, 4];
		Console.WriteLine(RunningSum(arr));
	}

	public static int[] RunningSum(int[] nums) {
		int sum = 0;
		int[] summed = new int[nums.Length];
		for (int i = 0; i < nums.Length; i++) {
			sum += nums[i];
			summed[i] = sum;
			Console.WriteLine(sum);
		}
		return summed;
	}
}

class HelloWorld {
	static void Main() {
	    int[] arr = [0, 1, 3, 12];
	    int[] nums = MoveOs(arr);
		Console.WriteLine(string.Join(", ", nums));
	}

	public static int[] MoveOs(int[] arr) {
		int count = 0;
		for (int i = 0; i < arr.Length; i++) {
			if (arr[i] != 0) {
				arr[count] = arr[i];
				count++;
			}
		}
		if (arr.Length == count) {
			return arr;
		}
		else {
			for (int j = count; j < arr.Length; j++) {
				arr[j] = 0;
			}
		}
		return arr;
	}

}


// Given an integer array, return a new array with the elements in reverse order.

// Input:  [1, 2, 3, 4, 5]
// Output: [5, 4, 3, 2, 1]

public static int[] reverse(int[] arr) {
		int[] nums = new int[arr.Length];
		for (int i = 0; i < arr.Length; i++) {
			nums[(arr.Length-1) - i] = arr[i];
		}
		return nums;
	}
  
public static int[] reverse(int[] arr) {
		for (int i = 0; i < arr.Length/2; i++) {
			temp = arr[i];
      arr[i] = arr[(arr.Length-1) - i];
      arr[(arr.Length-1) - i] = temp;
		}
		return arr;
	}



// Given an integer array of size n, return the element that appears more than n/2 times. One always exists.

// Input:  [3, 2, 3]
// Output: 3

// Input:  [2, 2, 1, 1, 2]
// Output: 2

public static int common(int[] arr) {
		int criteria = arr.Length/2;
		Dictionary<int, int> dict = new Dictionary<int, int>();
		for (int i = 0; i < arr.Length; i++) {
			if (dict.ContainsKey(arr[i])) {
				dict[arr[i]]++;
			}
			else {
				dict[arr[i]] = 1;
			}
		}
		foreach (KeyValuePair<int, int> j in dict) {
			if (j.Value > criteria) {
				return j.Key;
			}
		}
		return 0;
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