// Written by Ruth Ayele
// Due 2/16/2025

public class Solution
{
    // Initial health values
    private int manticoreHealth = 10;
    private int cityHealth = 15;
    private int manticoreDistance;
    private int round = 1;

    // Method to set Manticore's distance
    public void ManticoreDistance()
    {
        Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? ");
        string input = Console.ReadLine();
        manticoreDistance = ValidNumber(input);
        Console.Clear();
    }

    // game loop
    public void StartGame()
    {
        while (manticoreHealth > 0 && cityHealth > 0) 
        {
            DisplayStatus();
            int damage = CalculateDamage();

            Console.WriteLine("The cannon is expected to deal " + damage + " damage this round.");
            Console.Write("Enter desire cannon range: ");

            string input = Console.ReadLine();
            int target = ValidNumber(input);
            Attack(target, damage);
            if (manticoreHealth > 0)
            {
                 cityHealth--;
            }
            round++;
        }
        DisplayOutcome();
    }

    // Game status
    public void DisplayStatus()
    {
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    }

    // cannon damage
    public int CalculateDamage()
    {
        if (round % 3 == 0 && round % 5 == 0)
        {
            return 10;
        }
        else if (round % 3 == 0 || round % 5 == 0)
        {
            return 3;
        }
        else
        {
            return 1;
        }
    }

    public void Attack(int target, int damage)
    {
        if (target > manticoreDistance)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("That round OVERSHOT the target.");
        }
        else if (target < manticoreDistance)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The round FELL SHORT of the target.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("That round was a DIRECT HIT!");
            manticoreHealth -= damage;
        }
    }

    // final game outcome
    public void DisplayOutcome()
    {
        if (manticoreHealth <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The city of Consolas has been destroyed! The Manticore has won!");
        }
    }


    public int ValidNumber(string input)
    {
        int number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            number = number * 10 + (input[i] - '0');
        }
        

        // incase of invalid input
        while (number < 0 || number > 100)
        {
            Console.Write("Invalid input. Enter between 0 and 100.");
            input = Console.ReadLine();

            // resets number and converts new input to integer
            number = 0;
            for (int i = 0; i < input.Length; i++)
            {
            number = number * 10 + (input[i] - '0');
            }
        }
        return number; 

    } 
}

public class Program
{
    public static void Main()
    {
        Solution game = new Solution();
        game.ManticoreDistance();
        game.StartGame();
    }
}