// Written by Ruth Ayele
// Due 2/2/2025


namespace ClocktowerRepair
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Takes the number as input from the console
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Checks if the number is even or odd
            // Displays Tick for even and Tock for odd
            if (number % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
