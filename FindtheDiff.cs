public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        Dictionary<char, int> sCount = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (sCount.ContainsKey(c))
            {
                sCount[c]++;
            }
            else
            {
                sCount[c] = 1;
            }
        }

        foreach (char c in t)
        {
            if (!sCount.ContainsKey(c) || sCount[c] == 0)
            {
                return c; 
            }
            sCount[c]--; 
        }
        return '\0'; 
    }
}


