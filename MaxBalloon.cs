public class Solution
{
    public int MaxNumberOfBalloons(string text)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 0;
            }

            int b = charCount.ContainsKey('b') ? charCount['b'] : 0;
            int a = charCount.ContainsKey('a') ? charCount['a'] : 0;
            int l = charCount.ContainsKey('l') ? charCount['l'] / 2 : 0;
            int o = charCount.ContainsKey('o') ? charCount['o'] / 2 : 0;
            int n = charCount.ContainsKey('n') ? charCount['n'] : 0;

            return new List<int> { b, a, l, o, n }.Min();

        }
    }
}