public class Solution
{
    public void ItemPrice()
    {
        // Displays available items
        Console.WriteLine("The following items are available:");
        Console.WriteLine("1 - Rope");
        Console.WriteLine("2 - Torches");
        Console.WriteLine("3 - Climbing Equipment");
        Console.WriteLine("4 - Clean Water");
        Console.WriteLine("5 - Machete");
        Console.WriteLine("6 - Canoe");
        Console.WriteLine("7 - Food Supplies");
        Console.Write("What number do you want to see the price of? ");

        // Reads user input and converts it to an integer
        int itemNumber = Convert.ToInt32(Console.ReadLine());

        // Checks if the input is valid
        if (itemNumber < 1 || itemNumber > 7)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        // Asks for the user's name
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        // Determines the item name based on the selected number
        string item = itemNumber switch
        {
            1 => "Rope",
            2 => "Torches",
            3 => "Climbing Equipment",
            4 => "Clean Water",
            5 => "Machete",
            6 => "Canoe",
            7 => "Food Supplies"
        };

       // Assigns price based on the item
        int price = item switch
        {
            "Rope" => 10,
            "Torches" => 15,
            "Climbing Equipment" => 25,
            "Clean Water" => 1,
            "Machete" => 20,
            "Canoe" => 200,
            "Food Supplies" => 1
        };

        // Applies 50% discount
        if (userName == "Ruth")
        {
            price /= 2;
        }

        // Displays the final price
        Console.WriteLine($"{item} costs {price} gold.");
    }
}

public class Program
{
    public static void Main()
    {
        // Calls the method 
        Solution solution = new Solution();
        solution.ItemPrice();
    }
}