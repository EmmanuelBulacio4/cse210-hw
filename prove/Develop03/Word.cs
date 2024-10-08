class Word
{
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    public string Show()
    {
        return _text;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return ""; //Esto pongo para que no me dé error.
    }
    }