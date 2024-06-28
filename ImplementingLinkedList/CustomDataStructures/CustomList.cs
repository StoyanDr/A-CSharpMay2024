using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures;

public class CustomList<T>
{
    private const int initialCapacity = 2;
    private T[] items;
    private int count;

    public int Count
    {
        get
        {
            return count;
        }
    }
    public T this[int index]
    {
        get
        {
            ValidateIndex(index);
            return items[index];
        }
        set
        {
            ValidateIndex(index);
            items[index] = value;
        }
    }
    public CustomList()
    {
        items  = new T[initialCapacity];
        count = 0;
    }
    private void Resize()
    {
        int newSize = items.Length * 2;
        T[] newItems = new T[newSize];
        for (int i = 0; i < items.Length; i++)
        {
            newItems[i] = items[i];
        }
        items = newItems;
    }
    private void Shrink()
    {
        T[] newArr = new T[items.Length / 2];
        for(int i = 0; i <  newArr.Length; i++)
        {
            newArr[i] = items[i];
        }
        items = newArr;
    }
    public void ValidateIndex(int index)
    {
        if (index < 0 || index >= count) throw new IndexOutOfRangeException();
    }
    public void Add(T item)
    {
        if (count == items.Length) Resize();
        
        items[count++] = item;
    }
    public T Remove(int index)
    {
        ValidateIndex(index);
        T item = items[index];

        for (int i = index; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }
        count--;
        if(count * 2 <= items.Length)
        {
            Shrink();
        }
        return item;
    }
    public void Insert(int index, T item)
    {
        if (count == items.Length) this.Resize();
        for(int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }
        items[index] = item;
        count++;
    }
    public void Clear()
    {
        count = 0;
        items = new T[initialCapacity];
    }
    public void Swap(int index1, int index2)
    {
        ValidateIndex(index1);
        ValidateIndex(index2);
        T temp = items[index1];
        items[index1] = items[index2];
        items[index2] = temp;
    }
    public override string ToString()
    {
        string s = string.Empty;
        for(int i = 0; i < count; i++)
        {
            s += items[i] + " ";
        }
        return s;
    }
}
