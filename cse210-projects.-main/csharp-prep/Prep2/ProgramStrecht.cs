using System;

class program
{
    static void main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.Write("Please enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter; // Declare the letter variable
        string sign = ""; // Declare the sign variable and initialize it to an empty string

        if (gradePercentage >= 90 && gradePercentage < 100)
        {
            letter = "A";
            if (gradePercentage % 10 >= 7)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
            if (gradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
            if (gradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
            if (gradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (gradePercentage < 60 && gradePercentage >= 0)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Invalid grade percentage."); // Handle invalid input
            return; // Exit the program
        }

        if (letter == "F") // Handle F grades
        {
            sign = ""; // No sign
        }

        Console.WriteLine("Your letter grade is " + letter + sign); // Display the letter grade with sign

        if (gradePercentage >= 60 && letter != "F") // Handle passing grades
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else if (letter == "F") // Handle failing grades
        {
            Console.WriteLine("Sorry, you did not pass the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time."); // Handle borderline cases
        }
    }
}