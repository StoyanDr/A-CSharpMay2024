using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList;

public class RandomList : List<String>
{
    private Random random;
    public RandomList()
    {
        random = new();
    }
    public string RandomString()
    {
        int index = random.Next(0, Count);
        string removed = this[index];
        RemoveAt(index);
        return removed;
    }
}
