class Scriptures
{
    private Reference _reference;

    private List<Word> _words;

    public Scriptures(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        
        _words = new List<Word>();

        string [] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }


    }

    public void HideRandomWords(int numberToHide)
    {
        Console.WriteLine($"{_reference}:");
        
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool _isHiden()
    {
        return true; //Puse true para despues cambiarlo
    }
}