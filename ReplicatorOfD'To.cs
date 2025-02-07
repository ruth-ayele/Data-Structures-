public class Solution
{
    public void ReplicateArray()
    {
        int[] originalArray = new int[5];

        // Gets user input to fill original array
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter 5 numbers: ");
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] copiedArray = new int[5];

        // Replicates original array into copied array
        for (int item = 0; item < 5; item++)
            copiedArray[item] = originalArray[item];

        // Displays the content of both arrays
        for (int item = 0; item < 5; item++)
            Console.WriteLine(originalArray[item] + " and " + copiedArray[item]);


    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        solution.ReplicateArray();
    }
}



