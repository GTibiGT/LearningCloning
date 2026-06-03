
//Each row of an m×n matrix is sorted left-to-right. Return true if a target value exists in the matrix.

//Input:  [[1,3,5],[7,9,11],[13,15,17]], target = 9
//Output: true

using System;
class HelloWorld {
	static void Main() {
		int[][] arr = [[1, 3, 5], [7, 9, 11], [13, 15, 17]];
	    int target = 18;
		Console.WriteLine(SearchMatrix(arr, target));
	}

	// Each row of an m×n matrix is sorted left-to-right. Return true if a target value exists in the matrix.
	// Input:  [[1,3,5],[7,9,11],[13,15,17]], target = 9
	// Output: true
	public static bool SearchMatrix(int[][] matrix, int target) {
		for (int i = 0; i < matrix.Length; i++) {
			for (int j = 0; j < matrix[i].Length; j++) {
				if (matrix[i][j] == target) {
					return true;
				}
			}
		}
		return false;
	}
  
  }



public static bool SearchMatrix(int[][] matrix, int target) {
		for (int i = 0; i < matrix.Length; i++) {
    		int LastNum = matrix[i].Length - 1;
				if (matrix[i][0] <= target && target <= matrix[i][LastNum]) {
					int num = 0;
          while (num < matrix[i].Length){
          	if (matrix[i][num] == target){
            	return true;
            }
            num ++;
          }
			}
		}
		return false;
	}

public static bool SearchMatrix(int[][] matrix, int target) {
		for (int i = 0; i < matrix.Length; i++) {
			int left = 0;
			int right = matrix[i].Length - 1;
			while (left <= right) {
				int mid = (left+right)/2;
				if (matrix[i][mid] == target) {
					return true;
				}
				else if (matrix[i][mid] < target) {
					left = mid+1;
				}
				else {
					right = mid -1;
				}
			}
		}
		return false;
	}

