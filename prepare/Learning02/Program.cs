using System;

class Program
{
    static void Main(string[] args)
    {
         Job job1 = new Job();
         job1._company = "Dumbo";
         job1._jobTitle = "waiter";
         job1._startYear = 2015;
         job1._endYear = 2018;

         job1.DisplayJob();

    }
}