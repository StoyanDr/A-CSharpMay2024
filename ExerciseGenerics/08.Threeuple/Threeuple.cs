using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Threeuple;

public class Threeuple<T, V, T1>
{
    private T item1;
    private V item2;
    private T1 item3;

    public Threeuple(T item1, V item2, T1 item3)
    {
        this.item1 = item1;
        this.item2 = item2;
        this.item3 = item3;
    }

    public T Item1
    {
        get
        {
            return item1;
        }
        set
        {
            item1 = value;
        }
    }
    public V Item2
    {
        get
        {
            return item2;
        }
        set
        {
            item2 = value;
        }
    }
    public T1 Item3
    {
        get
        {
            return item3;
        }
        set
        {
            item3 = value;
        }
    }
    public override string ToString()
    {
        return $"{item1.ToString()} -> {item2.ToString()} -> {item3.ToString()}";
    }
}

