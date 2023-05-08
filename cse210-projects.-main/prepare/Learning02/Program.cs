using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Acme Inc.", new DateTime(2023, 5, 2), 100000);

        job1.DisplayJobDetails();

        Job job2 = new Job("Data Analyst", "XYZ Corp.", new DateTime(2023, 6, 1), 75000);

        job2.DisplayJobDetails();
    }
}
