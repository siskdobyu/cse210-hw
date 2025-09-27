using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Shell";
        job1._jobTitle = "Chemical Engineer";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Total";
        job2._jobTitle = "Plant Engineer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Jane Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // job1.Display();
        // job2.Display();
        myResume.Display();


    }

    


}
