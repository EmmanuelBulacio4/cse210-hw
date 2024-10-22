public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayDurationTime();
        GetReady();

        //Metodos para mostrar mensajes de breath in y bread out
        //Debe contener una cuenta regresiva
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"Breath in");
            ShowCountDown(3);

            Console.WriteLine("Breath out...");
            ShowCountDown(6);
            Console.WriteLine("\n");

        }
        //Mensaje de salida.
        DisplayEndingMessage();
    }
}