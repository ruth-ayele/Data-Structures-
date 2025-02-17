// Written by Ruth Ayele
// Due 2/16/2025

enum ArrowheadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }

public class Solution
{
    public class Arrow
    {
        public ArrowheadType Arrowhead { get; }
        public FletchingType Fletching { get; }    
        public float Length { get; }

        // Constructor to initialize the arrow components
        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            Length = length;
        }

   
        // Method to calculate the cost of the arrow
        public float GetCost()
        {
            float arrowheadCost = Arrowhead switch
            {
                ArrowheadType.Steel => 10,
                ArrowheadType.Wood => 3,
                ArrowheadType.Obsidian => 5,
                _ => 0
            };

            float fletchingCost = Fletching switch
            {
                FletchingType.Plastic => 10,
                FletchingType.TurkeyFeathers => 5,
                FletchingType.GooseFeathers => 3,
                _ => 0
            };

            // Shaft cost based on the length of the shaft
            float shaftCost = 0.05f * Length;
            return arrowheadCost + fletchingCost + shaftCost;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Arrow arrow = GetArrow(); 
        Console.WriteLine($"That arrow costs {arrow.GetCost()} gold."); 
        Console.WriteLine($"Arrowhead: {arrow.Arrowhead}"); 
        Console.WriteLine($"Fletching: {arrow.Fletching}"); 
        Console.WriteLine($"Length: {arrow.Length} cm"); 
    }

    // Method to gather all the data from the user and create an arrow
    public static Arrow GetArrow()
    {
        ArrowheadType arrowhead = GetArrowType(); 
        FletchingType fletching = GetFletchingType(); 
        float length = GetLength(); 

        return new Arrow(arrowhead, fletching, length); 
    }

    // Method to get the arrowhead type from the user
    public static ArrowheadType GetArrowType()
    {
        Console.Write("Arrowhead type (steel, wood, obsidian): ");
        string input = Console.ReadLine().ToLower();
        return input switch
        {
            "steel" => ArrowheadType.Steel,
            "wood" => ArrowheadType.Wood,
            "obsidian" => ArrowheadType.Obsidian,
            _ => ArrowheadType.Steel // Default to Steel
        };
    }

    // Method to get the fletching type from the user
    public static FletchingType GetFletchingType()
    {
        Console.WriteLine("Fletching type (plastic, turkey feathers, goose feathers): ");
        string input = Console.ReadLine().ToLower();
        return input switch
        {
            "plastic" => FletchingType.Plastic,
            "turkey feathers" => FletchingType.TurkeyFeathers,
            "goose feathers" => FletchingType.GooseFeathers,
            _ => FletchingType.Plastic // Default to Plastic
        };
    }

    // Method to get the arrow length
    public static float GetLength()
    {
        float length = 0;
        while (length < 60 || length > 100)
        {
            Console.Write("Arrow length (between 60 and 100): ");
            length = Convert.ToSingle(Console.ReadLine());
        }
        return length;
    }
}

