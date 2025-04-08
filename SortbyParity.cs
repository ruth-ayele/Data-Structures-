// Written by Ruth Ayele
// Due 04/03/2025

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        i = 0;
        j = nums.Length - 1;

        while (i < j)
        {
            while(i < j && nums[i] % 2 == 0) // if the element in the array is even
            {
                i++;
            }
            while (i < j && nums[i] % 2 == 1) // if the element in the array is odd
            {
                j--;
            }

            if (i < j)
            {
                int temp = nums[i]; // stores the element 
                nums[i] = nums[j] // moves it to the front
                nums[j] = temp; 
            }
        }
        return nums; // return sorted array
    }
}