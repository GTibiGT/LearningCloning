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
