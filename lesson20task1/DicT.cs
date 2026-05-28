using System.Collections;

namespace lesson20task1;

public class DicT<T, V> : IEnumerable<KeyValuePair<T, List<V>>>
{
    private Dictionary<T, List<V>> dict = new Dictionary<T, List<V>>();

    public void Add(T key, V value)
    {
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, new List<V>{value});
        }
        else
        {
            if (!dict[key].Contains(value))
            {
                dict[key].Add(value);
            }
        }
    }

    public void Dell(T key)
    {
        if (dict.ContainsKey(key)) { dict.Remove(key); }
    }
    
    public void DellTranslate(T key)
    {
        if (dict.ContainsKey(key)) { dict[key].Clear(); }
    }

    public void EditWord(T key, T newKey)
    {
        if (dict.ContainsKey(key) && !dict.ContainsKey(newKey))
        {
            List<V> temp = dict[key];
            dict.Remove(key);
            dict.Add(newKey, temp);
        }
    }

    public void Edit(T key, V value)
    {
        if (dict.ContainsKey(key)) { dict[key] = new List<V>{value}; }
    }
    
    public bool Find(T key)
    {
        if (dict.ContainsKey(key)) { return true; }
        return false;
    }

    public IEnumerator<KeyValuePair<T, List<V>>> GetEnumerator()
    {
        return dict.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public List<V> this[T index]
    {
        get
        {
            if (Find(index)) return dict[index]; 
            throw new KeyNotFoundException();
        }
        // set { dict[index] = value; }
    }
}