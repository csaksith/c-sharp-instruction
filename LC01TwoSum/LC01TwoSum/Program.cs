using System;

class Program {
    static void Main() {
        // Test case
        int[] nums = { 2,7,11,15 };
        int target = 9;

        // Create an instance of Solution and call TwoSum
        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums,target);

        // Print the result
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}

public class Solution {
    public int[] TwoSum(int[] nums,int target) {
        // Loop through each element
        for (int i = 0; i<nums.Length; i++) {
            // Start j from i + 1 to avoid using the same element twice
            for (int j = i+1; j<nums.Length; j++) {
                // If the sum of nums[i] and nums[j] equals target, return their indices
                if (nums[i]+nums[j]==target) {
                    return new int[] { i,j }; // Correct return placement
                }
            }
        }
        // This should never be reached as LeetCode guarantees a solution
        throw new ArgumentException("No solution found");
    }
}
