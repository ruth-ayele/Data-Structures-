public class Solution
{
    public void WatchTowers()
    {
        // Asks for user's input
        Console.WriteLine("Enter an x-value: ");
        Console.WriteLine("Enter a y-value");

        // Reads input and convert it to an integer
        int xValue = Convert.ToInt32(Console.ReadLine());
        int yValue = Convert.ToInt32(Console.ReadLine());

        // Determines enemy's direction based on x and y values
        if (xValue < 0 && yValue > 0)
        {
            Console.WriteLine("The enemy is to the northwest!");
        }
        else if (xValue == 0 && yValue > 0)
        {
            Console.WriteLine("The enemy is to the north!");
        }
        else if (xValue > 0 && yValue > 0)
        {
            Console.WriteLine("The enemy is to the northeast!");
        }
        else if (xValue < 0 && yValue == 0)
        {
            Console.WriteLine("The enemy is to the west!");
        }
        else if (xValue == 0 && yValue == 0)
        {
            Console.WriteLine("The enemy is here!");
        }
        else if (xValue > 0 && yValue == 0)
        {
            Console.WriteLine("The enemy is to the east!");
        }
        else if (xValue < 0 && yValue < 0)
        {
            Console.WriteLine("The enemy is to the southwest!");
        }
        else if (xValue == 0 && yValue < 0)
        {
            Console.WriteLine("The enemy is to the south!");
        }
        else if (xValue > 0 && yValue < 0)
        {
            Console.WriteLine("The enemy is to the southeast!");
        }

    }
}

public class Program
{
    public static void Main()
    {
        // Calls the solution class
        Solution solution = new Solution();
        solution.WatchTowers();
    }
}
