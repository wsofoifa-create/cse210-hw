using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity(
            new DateTime(2022, 11, 3), 30, 4.8));

        activities.Add(new CyclingActivity(
            new DateTime(2022, 11, 4), 45, 20));

        activities.Add(new SwimmingActivity(
            new DateTime(2022, 11, 5), 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}