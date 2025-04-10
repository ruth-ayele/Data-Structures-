public class Program
{
    public static int FirstUniqChar(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        for (int i = 0; i < dict.Count;i++)
        {
            if (charCount[s[i]] == 1)
            {
                return i; 
            }
        }
        return -1;
    }
}