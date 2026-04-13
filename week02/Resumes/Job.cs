using System;

public class Job
{
    // Attributes (state)
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Method (behavior)
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}