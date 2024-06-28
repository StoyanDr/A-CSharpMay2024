using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator;

public class ListyIterator<T> : IEnumerable<T>
{
    private int index = 0;
    private List<T> list;

    public ListyIterator(List<T> list)
    {
        this.list = list;
    }
    public bool MoveNext()
    {
        if(HasNext())
        {
            index++;
            return true;
        }
        return false;
    }
    public bool HasNext()
    {
        return index + 1 < list.Count;
    }
    public void Print()
    {
        if (list.Count == 0) throw new Exception("Invalid Operation!");
        Console.WriteLine(list[index]);
    }
    public void PrintAll()
    {
        foreach(T item in this)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < list.Count; i++)
        {
            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
}
