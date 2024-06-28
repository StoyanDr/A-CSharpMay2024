using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack;

public class CustomStack<T> : IEnumerable<T>
{
    private List<T> list;
    public CustomStack()
    {
        list = new();
    }
    public void Push(T item)
    {
        list.Add(item);
    }
    public T Pop()
    {
        if (list.Count == 0) throw new InvalidOperationException("No elements");
        T a = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return a;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for(int i = list.Count - 1; i >= 0; i--)
            yield return list[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
}
