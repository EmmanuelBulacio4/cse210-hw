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
        //Create the constructor solo con el mensaje de bienvenida.
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(""); // Don´t forget to write the message!
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(""); // Don´t forget to write the message!
    }

    public void ShowSpinner()
    {   
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
        DateTime StartTime = DateTime.Now;
        DateTime endTime = StartTime.AddSeconds(_duration);

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