using System;

public class Solution {
    public static void Main(string[] args) {
        // Създаваме инстанция на Solution
        var solution = new Solution();
        
        // Дефинираме тестов масив и целева стойност
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        
        // Извикваме метода TwoSum и печатаме резултата
        int[] result = solution.TwoSum(nums, target);
        if (result != null) {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        } else {
            Console.WriteLine("No two sum solution found.");
        }
    }
    
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        return null; // Връщаме null ако решение не бъде намерено
    }
}