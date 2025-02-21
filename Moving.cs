// Written by Ruth Ayele
// Due 02/20/2025

public class Solution
{
    public static string Move(string input)
    {
        input = input.ToLower();

        string result = "";

        foreach (char c in input)
        {
            if (c >= 'a' && c <= 'y')
            {
                // shifts to the next letter
                result += (char)(c + 1);
            }
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.Move("hello"));
        Console.WriteLine(solution.Move("bye"));
        Console.WriteLine(solution.Move("welcome"));
    }
}

