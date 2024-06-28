using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures;

public class CustomStack<T>
{
    private T[] items;
    private const int initialCapacity = 4;
    private int count;

    public CustomStack()
    {
        items = new T[initialCapacity];
        count = 0;
    }
    public int Count => count;
    public void Resize()
    {
        T[] arr = new T[items.Length * 2];
        for(int i = 0; i < count; i++)
        {
            arr[i] = items[i];
        }
        items = arr;
    }
    public void Shrink()
    {
        T[]arr = new T[items.Length / 2];
        for(int i = 0; i < count; i++)
        {
            arr[i] = items[i];
        }
        items = arr;
    }
    public void Push(T item)
    {
        if (count == items.Length) Resize();
        items[count++] = item;
    }
    public T Pop()
    {
        if (count == 0) throw new Exception("Empty queue!");
        count--;
        T item = items[count];
        if (count * 2 <= items.Length) Shrink();
        return item;
    }
    public T Peek()
    {
        if (count == 0) throw new Exception("Empty queue!");
        return items[count - 1];
    }
    public void ForEach(Action<T> action)
    {
        for(int i = 0; i < count; i++)
        {
            action(items[i]);
        }
    }
    public override string ToString()
    {
        string s = string.Empty;
        for (int i = 0; i < count; i++)
        {
            s += items[i] + " ";
        }
        return s;
    }
}
