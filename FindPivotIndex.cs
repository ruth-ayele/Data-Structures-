public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int total = 0;

        // Calculate total sum manually
        for (int i = 0; i < nums.Length; i++)
        {
            total += nums[i];
        }

        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = total - leftSum - nums[i];

            if (leftSum == rightSum)
            {
                return i;
            }

            leftSum += nums[i];
        }
        // if no index exists
        return -1;
    }
}
