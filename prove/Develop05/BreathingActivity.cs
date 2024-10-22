public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()}.\n");
        Console.WriteLine(GetDescription());
        
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.WriteLine("Get Ready...\n");
        ShowSpinner(4);
        Thread.Sleep(2000);

        int timer = 0;

        while (GetDuration()> timer)
        {
            Console.WriteLine($"Breath in{ShowCountDown}");
            
        }

        //Metodos para mostrar mensajes de breath in y bread out
    //Debe contener una cuenta regresiva


    //Mensaje de salida.
    }
}