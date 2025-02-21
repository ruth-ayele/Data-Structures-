// Written by Ruth Ayele
// Due 02/20/2025

public class Solution
{
    public int CountWords (string sentence)
    {
        // checks if the sentence is null or empty 
        if (sentence == null || sentence == "")
        {  
            return 0; 
        }

        int count = 1;
        for (int i = 0; i < sentence.Length; i++)
        {
            // Checks for a space followed by a non-space character
            if (sentence[i] == ' ' && i + 1 < sentence.Length && sentence[i + 1] != ' ')
            {
                count++;
            }
        }
        return count;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.CountWords("Just an example here move along"));
        Console.WriteLine(solution.CountWords("This is a test"));
        Console.WriteLine(solution.CountWords("What an easy task, right"));
    }
}