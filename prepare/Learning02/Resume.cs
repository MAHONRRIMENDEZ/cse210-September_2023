using System;
using System.Threading.Tasks.Dataflow;
public class Resume
{
    public string _name;
    public string _lastName;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name} {_lastName}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}