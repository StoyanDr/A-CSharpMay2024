using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack;

public class StackOfStrings : Stack<string>
{
    public bool IsEmpty()
    {
        return Count == 0;
    }
    public void AddRange(IEnumerable<string> values)
    {
        foreach (string value in values)
        {
            Push(value);
        }
    }
}
