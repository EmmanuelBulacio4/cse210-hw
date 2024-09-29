using System.IO; 
public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //bucle para mostrar todas las entradas. Llama al Entry.Display(); en cada ciclo.
    }

    public void SaveToFile(string file)
    {

    } 

    static void LoadFromFile(string file)
    {

    }
} 