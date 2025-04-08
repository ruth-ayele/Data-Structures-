// Written by Ruth Ayele
// Due 04/03/2025

public class Solution
{
    public int Merge(int[] nums1, int m, int[] nums2, int n)
    {
        i = m - 1; // last valid element in nums1
        j = n - 1; // last element in nums2
        k = m + n - 1; // last position in nums1

        while (i <= 0 && j <= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i++;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

    }
}