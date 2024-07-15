using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class Smartphone : ICallable, IBrowsable
{
    public void Browse(string url)
    {
        for(int i = 0; i < url.Length; i++)
        {
            if (url[i] >= '0' && url[i] <= '9') throw new ArgumentException("Invalid URL!");
        }
        Console.WriteLine($"Browsing: {url}!");
    }

    public void Call(string number)
    {
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] < '0' || number[i] > '9') throw new ArgumentException("Invalid number!");
        }
        Console.WriteLine($"Calling... {number}");
    }
}
