// Written by Ruth Ayele
// Due 04/03/2025
using System;
using System.Collections.Generic;
public class Solution
{
    // Method to find two numbers that add up to the target
    public int[] TwoSum(int[] nums, int target)
    {
        // To store numbers and their indices
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        // Loops through the array
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }
            numDict[nums[i]] = i; // Stores the number with its index
        }
        return new int[] { }; // Never reached
    }

}