// Written by Ruth Ayele
// Due 04/03/2025

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0; // counts the non-val elements

        // Iterates through the array
        for (int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] != val) // moves it to the front 
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}
