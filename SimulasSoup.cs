// Written by Ruth Ayele
// Due 2/16/2025

enum FoodType { Soup, Stew, Gumbo }
enum Ingredient { Mushroom, Chicken, Carrot, Potato }
enum Seasoning { Spicy, Salty, Sweet }

public class Solution
{
    public void SoupMaker()
    {
        while (true)
        {
           // Displays menu and gets users choices
            Console.WriteLine("Choose a type: soup, stew, gumbo");
            FoodType type =  SoupType(Console.ReadLine().ToLower());
            
            Console.WriteLine("Choose an ingredient: mushrooms, chicken, carrots, potatoes");
            Ingredient ingredient = MainIngredient(Console.ReadLine().ToLower());
           
            Console.WriteLine("Choose a seasoning: spicy, salty, sweet");
            Seasoning seasoning = GetSeasoning(Console.ReadLine().ToLower());
            
            // Displays soup
            Console.WriteLine($"You made a {seasoning} {ingredient} {type}.");

        }
    }

    // asks user for soup type
    public FoodType SoupType(string input)
    {
        return input switch
        {
            "soup" => FoodType.Soup,
            "stew" => FoodType.Stew,
            "gumbo" => FoodType.Gumbo
            _ =>
            {
                Console.WriteLine("Invalid type! Defaulting to Soup.");
                return FoodType.Soup;
            }
        }; 
    }

    // asks user for what ingredients they want in soup
    public Ingredient MainIngredient(string input)
    {
        return input switch
        {
            "mushroom" => Ingredient.Mushroom,
            "chicken" => Ingredient.Chicken,
            "carrot" => Ingredient.Carrot,
            "potato" => Ingredient.Potato
            _ =>
            {
                Console.WriteLine("Invalid ingredient! Defaulting to Mushrooms.");
                return Ingredient.Mushrooms;
            }
        };
    }
    
    // asks user for seasonings they want
    public Seasoning GetSeasoning(string input) 
    {
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet,
        _ =>
        {
            Console.WriteLine("Invalid seasoning! Defaulting to Spicy.");
            return Seasoning.Spicy;
        }
        };
    }

}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        solution.SoupMaker();
    }
}

