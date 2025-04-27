public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int insertPos = 0;

        // Moves all non-zero elements forward
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }

        // Fills the remaining positions with zeros
        for (int i = insertPos; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}

