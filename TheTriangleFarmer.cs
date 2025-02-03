// Written by Ruth Ayele
// Due 2/2/2025

namespace TriangleCalculator
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            // Asks for user input 
            // Reads input and converts from string to double

            Console.WriteLine("Enter the base of the triangle:");
            double baseSize = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculates the area of triangle
            double area = (baseSize * height) / 2;

            // Displays the calculated area to the user
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}