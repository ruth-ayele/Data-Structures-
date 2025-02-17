// Written by Ruth Ayele
// Due 2/16/2025


// Possible states of the chest
enum ChestState
{
    Locked, 
    Unlocked,
    Open
}

public class Solution
{
    // Initially a locked chest
    ChestState state = ChestState.Locked;

    public void Run()
    {
        while(true)
        {
            Console.WriteLine($"The chest is {state}. What do you want to do?");
            string input = Console.ReadLine().ToLower();

            // chests state changes based off user input
            if (input == "unlock")
            {
                Unlock();
            }
            else if (input == "open")
            {
                Open();
            }
            else if (input == "close")
            {
                Close();
            }
            else if (input == "lock")
            {
                Lock();
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
        // Method to unlock the chest
        public void Unlock()
        {
            if (state == ChestState.Locked)
            {
                state = ChestState.Unlocked;
                Console.WriteLine("You unlock the chest.");
            }
            else
            {
                Console.WriteLine("You can't unlock the chest now.");
            }
        }

        // method to lock the chest
        public void Lock()
        {
            if (state == ChestState.Unlocked)
            {
                state = ChestState.Locked;
                Console.WriteLine("You lock the chest.");
            }
            else
            {
                Console.WriteLine("You can't lock the chest now.");
            }
        }

        // method to open the chest
        public void Open()
        {
            if (state == ChestState.Unlocked)
            {
                state = ChestState.Open;
                Console.WriteLine("You open the chest.");
            }
            else
            {
                Console.WriteLine("You can't open the chest now.");
            }
        }

        // method to close the chest
        public void Close()
        {
            if (state == ChestState.Open)
            {
                state = ChestState.Unlocked;
                Console.WriteLine("You close the chest.");
            }
            else
            {
                Console.WriteLine("You can't close the chest now.");
            }
        }
}
    
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        solution.Run();
    }
}
