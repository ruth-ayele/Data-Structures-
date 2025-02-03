// Written by Ruth Ayele
// Due 2/2/2025

namespace DefenseOfConsolas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Asks for user input
            // Reads input and converts it to an integer
            Console.WriteLine("Target row? ");
            int targetRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Target column? ");
            int targetColumn = Convert.ToInt32(Console.ReadLine());

            // Computes the neighboring rows and columns to deploy the squad
            int[] rows = {-1, 1, 0, 0}; 
            int[] columns = {0, 0, -1, 1};

            // Dark Blue for deployment instructions
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Displays the deployment instructions
            Console.WriteLine("Deploy to:");

            foreach (int row in rows)
            {
                foreach (int column in columns)
                {
                    int Row = targetRow + row;
                    int Col = targetColumn + column;
                    Console.WriteLine(Row + ", " + Col);
                }
            }

            // Changes the window title
            Console.Title = "Defense of Consolas";

            // Plays a beep sound when results are displayed
            Console.Beep();
        }
    }
}
