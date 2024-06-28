using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Froggy;

public class Lake : IEnumerable<int>
{
    List<int> list;

    public Lake(string input)
    {
       list = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
    }

    public IEnumerator<int> GetEnumerator()
    {
        List<int> even = new();
        List<int> odd = new();
        for(int i = 0; i < list.Count; i++)
        {
            if(i % 2 == 0) odd.Add(list[i]);
            else even.Add(list[i]);
        }
        even.Reverse();
        for(int i = 0; i < odd.Count; i++)
            yield return odd[i];
        for (int i = 0; i < even.Count; i++)
            yield return even[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
