using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures;

public class CustomQueue<T>
{
    private T[] items;
    private const int initialSize = 4;
    private int count;

    public int Count { get { return count; } }

    public CustomQueue()
    {
        items = new T[initialSize];
        count = 0;
    }
    private void Resize()
    {
        T[] arr = new T[items.Length * 2];
        for (int i = 0; i < count; i++)
        {
            arr[i] = items[i];
        }
        items = arr;
    }
    private void Shrink()
    {
        T[] arr = new T[items.Length / 2];
        for (int i = 0; i < count; i++) arr[i] = items[i];
        items = arr;
    }
    public void Enqueue(T item)
    {
        if (count == items.Length) Resize();
        items[count++] = item;
    }
    public T Dequeue()
    {
        if (count == 0) throw new Exception("Empty queue!");
        T item = items[0];
        for(int i = 0; i < count  - 1; i++)
        {
            items[i] = items[i + 1];
        }
        count--;
        if (count * 2 <= items.Length) Shrink();
        return item;
    }
    public T Peek()
    {
        if (count == 0) throw new Exception("Empty queue!");
        return items[0];
    }
    public void Clear()
    {
        count = 0;
        items = new T[initialSize];
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
