using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.Write("Please enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter; // Declare the letter variable

        if (gradePercentage >= 90 && gradePercentage <= 100)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine("Your letter grade is " + letter); // Display the letter grade
       
        if (gradePercentage >= 60)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }
}