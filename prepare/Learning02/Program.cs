using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Dumbo Restaurant";
        job1._jobTitle = "Waiter";
        job1._startYear = 2015;
        job1._endYear = 2018;

        job1.Display();

        Job job2 = new Job();
        job2._company = "Live Marketing Solutions";
        job2._jobTitle = "Sales Man";
        job2._startYear = 2018;
        job2._endYear = 2019;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Mahonrri Mendez";
        //myResume._lastName = "Mendez";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); 
        
    }
}