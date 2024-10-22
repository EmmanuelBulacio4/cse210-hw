using System;
using System.Diagnostics;
public class Activity  //This is the base class!
{
    private string _name;
    private string _description;
    private int _duration;
    private double _timing;

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
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}.\n");
        Console.WriteLine(GetDescription());
    }

    public void DisplayDurationTime()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
    }

    public void GetReady()
    {
        Console.WriteLine("\nGet Ready...\n");
        ShowSpinner(3);
        Thread.Sleep(1500);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done"); 
        ShowSpinner(3);
    }

    public void ShowSpinner(int lapse)
    {    
        _timing = lapse;
        List<string> animation = ["|", "/", "-", "\\", "|", "/", "-", "\\",];

        DateTime StartTime = DateTime.Now; //This variable is static, it doesnt change. It is usefull in order to set the endTime only.
        DateTime endTime = StartTime.AddSeconds(_timing);

        int i = 0;

        do
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            StartTime.AddSeconds(1);
            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }while (DateTime.Now < endTime); //With the DateTime.Now the time is actualizing every minute so it makes the loop finishes when the endTime is reached.
    }

    public void ShowCountDown(int lapse)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(lapse);

        
        while (DateTime.Now < endTime)
        {
            // Mostrar el número de segundos restantes
            Console.Write(lapse);
        
            Thread.Sleep(1000);  // Esperar 1 segundo

            lapse--;  // Reducir el valor de lapse en cada iteración

            // Borrar el número mostrado antes de imprimir el siguiente
            Console.Write("\b\b");  // Retroceder para sobrescribir el número
        }
        Console.WriteLine();
    }
}