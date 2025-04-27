public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int> ();
        int majority = nums.Length / 2;
        
        foreach (int num in nums)
        {
            if (!count.ContainsKey(nums)
            {
                count[num] = 0;
            }
            count[num]++;

            if (count[num] > majority)
            {
                return num;
            }
        }
        return -1;
    }
}

