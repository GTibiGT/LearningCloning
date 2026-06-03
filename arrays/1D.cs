
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
