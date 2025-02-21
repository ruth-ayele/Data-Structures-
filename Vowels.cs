// Written by Ruth Ayele
// Due 02/20/2025

public class Solution
{ 
    public static string FirstVowels(string input, int n)
    {
        string vowels = "aeiou";
        string result = "";

        foreach (char c in input.ToLower())
        {
            bool isVowel = false;
            for (int i = 0; i < vowels.Length; i++) 
            {
                if (c == vowels[i])
                {
                    isVowel = true;
                }
            }

            if (isVowel)
            {
                result += c;
                if (result.Length == n)
                {
                    return result;
                }
            }
        }

        // if there are not enough vowels
        return "invalid";
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.FirstVowels("sharpening skills", 3);
        Console.WriteLine(solution.FirstVowels("major league", 5);
        Console.WriteLine(solution.FirstVowels("hostess", 5);
    }
}

