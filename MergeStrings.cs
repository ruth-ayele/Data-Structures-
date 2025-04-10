public class Solution
{
    public string MergeString(string word1, string word2)
    {
        string merged = "";
        int maxLength = Math.Max(word1.Length, word2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < word1.Length)
            {
                merged += word1[i];
            }
            if (i < word2.Length)
            {
                merged += word2[i];
            }
        }
        return merged;
    }
}

