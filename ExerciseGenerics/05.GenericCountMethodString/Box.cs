using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString;

public class Box<T> : IComparable<Box<T>>
    where T : IComparable<T> 
{
    private T value;
    public Box(T value)
    {
        this.value = value;
    }
    public override string ToString()
    {
        return $"{value.GetType()}: {value}";
    }
    public int CompareTo(Box<T> box)
    {
        return value.CompareTo(box.value);
    }

}
