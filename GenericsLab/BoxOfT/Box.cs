using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT;

public class Box<T>
{
    private List<T> list;
    public int Count => list.Count;
    public Box()
    {
        list = new();
    }
    public void Add(T item)
    {
        list.Add(item);
    }
    public T Remove()
    {
        T item = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return item;
    }
}
