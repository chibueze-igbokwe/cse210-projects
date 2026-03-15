// week02/Resumes/Job.cs
using System;

public class Job
{
    // Member variables (attributes)
    // These store information about a job
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;

    // Method to display the job information
    public void Display()
    {
        // Display in required format:
        // Job Title (Company) StartYear-EndYear
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}