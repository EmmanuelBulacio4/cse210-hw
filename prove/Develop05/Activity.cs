using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
public class Activity  //This is the base class!
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 30;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(""); // Don´t forget to write the message!
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done"); 
        ShowSpinner(3);
    }

    public void ShowSpinner(int duration)
    {    
        _duration = duration;
        List<string> animation = ["|", "/", "-", "\\", "|", "/", "-", "\\",];

        DateTime StartTime = DateTime.Now;
        DateTime endTime = StartTime.AddSeconds(_duration);

        int i = 0;

        while (StartTime < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        
        while (endTime > startTime)
        {
            for (int i = _duration; i>0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
                if (i==3)
                {
                    Console.Write("\b\b\b");
                }
            }
        }
    }
}