using System;

public class Job
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public int Salary { get; set; }

    public Job(string title, string description, DateTime startDate, int salary)
    {
        Title = title;
        Description = description;
        StartDate = startDate;
        Salary = salary;
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Start Date: {StartDate}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}