public class Solution
{
    public int ValidNumber()
    {
        int num;
        while (true)
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
            string input = Console.ReadLine();

            num = Convert.ToInt32(input);

            if (num >= 0 && num <= 100)
            {
                return num;
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    public void GuessNumber(int target)
    {
        int guess = -1; 
        while (guess != target)
        {
            Console.Write("What is your next guess? ");
            string input =  Console.ReadLine();

            guess = Convert.ToInt32(input);

            if (guess < target)
            {
                Console.WriteLine(guess + " is too low.");

            }
            else if (guess > target)
            {
                Console.WriteLine(guess + " is too high.");
            }
            else
            {
                Console.WriteLine("You guessed the number!");
            }
        }
    }

    public void StartGame()
    {
        int numberToGuess = ValidNumber();
        Console.Clear();

        Console.WriteLine("User 2,guess the number.");
        GuessNumber(numberToGuess);
        
    }

    
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        solution.StartGame();
    }
}