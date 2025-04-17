using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 4, 15), 30, 5.0),
            new Cycling(new DateTime(2025, 4, 16), 60, 20.0),
            new Swimming(new DateTime(2025, 4, 17), 45, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}