// week02/Resumes/Resume.cs
using System;
using System.Collections.Generic;

public class Resume
{
    // Member variable for the person's name
    public string _name = "";

    // List to store multiple Job objects
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume
    public void Display()
    {
        // Display the name
        Console.WriteLine($"Name: {_name}");

        // Display the jobs header
        Console.WriteLine("Jobs:");

        // Loop through each job in the list
        foreach (Job job in _jobs)
        {
            // Call the Display method of each Job
            job.Display();
        }
    }
}