
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
