public class Solution
{
    public int CountSegments(string s)
    {
        List<string> segment = new List<string>();
        string current = "";

        foreach (char c in s)
        {
            if (c != ' ')
            {
                current += c;
            }
            else
            {
                segment.Add(current);
                current = "";
            }
        }

        // Adds the last segment if its not empty
        if (current != "")
        {
            segment.Add(current);
        }

        return segment.Count;
    }
}