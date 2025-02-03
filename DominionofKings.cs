// Written by Ruth Ayele
// Due 2/2/2025

namespace KingdomPointSystem
{
    public class Program
    {
        public static void Main(string [] args)
        {
            // Asks for user input
            // Reads input and converts it to an integer

            Console.WriteLine("Enter the number of provinces you rule: ");
            int provinces = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of duchies you rule: ");
            int duchies = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of estates you rule: ");
            int estates = Convert.ToInt32(Console.ReadLine());

            // Calculates total points by the points assigned to each entity
            int totalPoints = (provinces * 6) + (duchies * 3) + (estates * 1);

            // Displays total point to user
            Console.WriteLine("Your total kingdom score is: " + totalPoints + " points.");
        }
    }
}
