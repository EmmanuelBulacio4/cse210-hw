using System;

public class Job
{
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;
    public string _compani = "";

    public Job()
    {
    }
        public void DisplayJob()
        {
            Console.WriteLine($"{_jobTitle}");
        }

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_compani}) {_startYear}-{_endYear}");
        }
    }
