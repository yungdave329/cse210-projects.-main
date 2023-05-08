using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int>();

        while (true) {
            Console.Write("Enter a number (0 to stop): ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0) {
                break;
            }

            numbers.Add(num);
        }

        int sum = 0;
        int max = int.MinValue;
        int minPositive = int.MaxValue;

        foreach (int num in numbers) {
            sum += num;

            if (num > max) {
                max = num;
            }

            if (num > 0 && num < minPositive) {
                minPositive = num;
            }
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The largest number is: " + max);

        if (minPositive == int.MaxValue) {
            Console.WriteLine("There were no positive numbers entered.");
        } else {
            Console.WriteLine("The smallest positive number is: " + minPositive);
        }

        numbers.Sort();
        Console.WriteLine("The numbers in sorted order are:");
        foreach (int num in numbers) {
            Console.WriteLine(num);
        }
    }
}