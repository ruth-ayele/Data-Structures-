// Written by Ruth Ayele
// Due 02/20/2025

public class Solution
{
    public static bool IsInOrder(string input)
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] > input[i + 1])
            {
                return false;
            }
        }
        // If all characters are in order
        return true;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.Write(solution.IsInOrder("abc"));
        Console.Write(solution.IsInOrder("edabit"));
        Console.Write(solution.IsInOrder("123"));
        Console.Write(solution.IsInOrder("xyzz"));
    }
}