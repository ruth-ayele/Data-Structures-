public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> pairs = new Dictionary<char, char>();
        pairs.Add(')', '(');
        pairs.Add(']', '[');
        pairs.Add('}', '{');

        List<char> stack = new List<char>();
        int stackCount = 0; // keeps track of how many items are in the stack

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (pairs.ContainsKey(ch))
            {
                if (stackCount == 0)
                {
                    return false;
                }

                char top = stack[stackCount - 1];

                if (top == pairs[ch])
                {
                    stackCount--; // basically popping 
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (stackCount < stack.Count)
                {
                    stack[stackCount] = ch;
                }
                else
                {
                    stack.Add(ch);
                }
                stackCount++;
            }
        }

        return stackCount == 0;
    }
}
