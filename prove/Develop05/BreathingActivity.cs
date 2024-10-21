public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("Wellcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int _duration = Console.ReadLine();
    }

    public void Run()
    {
        
    }

    //Metodos para mostrar mensajes de breath in y bread out
    //Debe contener una cuenta regresiva
    //Entre paso y paso debe haber una pausa Thread.Sleep(3000)

    //Mensaje de salida.
}