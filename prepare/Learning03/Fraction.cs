public class Fraction
{
    private int _top;
    private int _bottom;

    public void fraction()
    {
        Console.WriteLine("1/1");
    }

    Fraction (int wholeNumber)
    {
        _top = wholeNumber;
    }

    Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public Fraction()
    {
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom ()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetFractionString()
    {
        return 1; //tengo que completar este method.
    }

    public int GetDecimalValue(double decNumber)
    {
        return 1; //Evaluar como hacer esto
    }
}