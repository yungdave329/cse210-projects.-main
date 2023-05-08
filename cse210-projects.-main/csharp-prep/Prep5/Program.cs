using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        Console.Write("Please enter your favorite number: ");
        string favoriteNumberString = Console.ReadLine();
        int favoriteNumber = int.Parse(favoriteNumberString);
        int favoriteNumberSquared = favoriteNumber * favoriteNumber;
        Console.WriteLine(name + " ,the square of your favorite number is: " + favoriteNumberSquared);
    }
}