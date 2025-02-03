// Written by Ruth Ayele
// Due 2/2/2025

namespace ChocolateEggDistribution 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Asks for user input
            Console.WriteLine("Enter the total number of chocolate eggs collected today:");

            // Reads input and converts it to an integer
            int totalEggs = Convert.ToInt32(Console.ReadLine());

            // Calculates how many eggs each sister will get 
            int eggsPerSister = totalEggs / 4;

            // Remainder eggs that the duckbear will get
            int duckbearEggs = totalEggs % 4;
            
            Console.WriteLine("Each sister gets: " + eggsPerSister + " chocolate eggs.");
            Console.WriteLine("The duckbear gets: " + duckbearEggs + " chocolate eggs.");
        }
    }
}


// Q: What are three total egg counts where the duckbear gets more eggs than each sister does?
// A: 1 egg (each sis: 0, duckbear: 1), 2 eggs (each sis: 0, duckbear: 2), and 3 eggs (each sis: 0, duckbear: 3)

