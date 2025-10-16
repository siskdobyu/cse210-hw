using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 10, 17), 10, 5.8),
            new Cycling(new DateTime(2025, 10, 17), 20, 6.7),
            new Swimming(new DateTime(2025, 10, 17), 15, 15)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
