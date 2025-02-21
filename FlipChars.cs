// Written by Ruth Ayele
// Due 02/20/2025

public class Solution
{
    public static string FlipEndChars(string input)
    {
        // Checks if the string length is less than 2
        if (input.Length < 2)
        {
            return "Incompatible.";
        }

        // Checks if the first and last characters are the same
        if (input[0] == input[input.Length - 1])
        {
            return "Two's a pair.";
        }

        // Swaps first and last characters
        return input[input.Length - 1] + input.Substring(1, input.Length - 2) + input[0];
    }
       
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.FlipEndChars("Cat, dog, and mouse."));
        Console.WriteLine(solution.FlipEndChars("ada"));
        Console.WriteLine(solution.FlipEndChars("Ada"));
        Console.WriteLine(solution.FlipEndChars("z"));
    }
}