namespace lesson20task1;

public class DicT<T, V>
{
    private Dictionary<T, V> dict = new Dictionary<T, V>();

    public void Add(T key, V value)
    {
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, value);
            Console.WriteLine($"Word {key} added");
        }else
        {
            Console.WriteLine($"This word is already in the dictionary");
        }
    }

    public void Dell(T key)
    {
        if (dict.ContainsKey(key))
        {
            dict.Remove(key);
            Console.WriteLine($"Word {key} deleted");
        }
        else
        {
            Console.WriteLine($"Word {key} not found");
        }
    }
    
    public void DellTranslate(T key)
    {
        if (dict.ContainsKey(key))
        {
            dict[key] = default(V)!; 
            Console.WriteLine($"Translation for {key} cleared");
        }
        else
        {
            Console.WriteLine($"Word {key} not found");
        }
    }

    public void EditWord(T key, T newKey)
    {
        if (dict.ContainsKey(key) && !dict.ContainsKey(newKey))
        {
            V temp = dict[key];
            dict.Remove(key);
            dict.Add(newKey, temp);
            Console.WriteLine($"Word edited");
        }
        else
        {
            Console.WriteLine($"Word {key} not found");
        }
    }

    public void Edit(T key, V value)
    {
        if (dict.ContainsKey(key))
        {
            dict[key] = value;
            Console.WriteLine($"Translate edited");
        }
        else
        {
            Console.WriteLine($"Word {key} not found");
        }
    }
    
    public void Find(T key)
    {
        if (dict.ContainsKey(key))
        {
            Console.WriteLine($"Translate of {key} is {dict[key]}");
        }
        else
        {
            Console.WriteLine($"Word {key} not found");
        }
    }
}