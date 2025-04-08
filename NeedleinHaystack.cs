// Written by Ruth Ayele
// Due 04/03/2025

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        // Loops through the haystack string
        for (int i = 0; i < haystack.Length; i++)
        {
            // checks if the substring from index i matches the needle
            if (haystack.Substring(i, needle.Length) == needle) 
            {
                return i; // if match is found
            }
        }
        return -1; // if no match is found
    }

}