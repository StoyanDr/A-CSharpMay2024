using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple;

public class CustomTuple<T, V>
{
    private T item1;
    private V item2;

    public CustomTuple(T item1, V item2)
    {
        this.item1 = item1;
        this.item2 = item2;
    }

    public T Item1
    {
        get
        {
            return item1;
        }
    }
    public V Item2
    {
        get
        {
            return item2;
        }
    }
    public override string ToString()
    {
        return $"{item1.ToString()} -> {item2.ToString()}";
    }
}
