using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class StationaryPhone : ICallable
{
    public void Call(string number)
    {
        for(int i = 0; i < number.Length; i++)
        {
            if (number[i] < '0' || number[i] > '9') throw new ArgumentException("Invalid number!");
        }
        Console.WriteLine($"Dialing... {number}");
    }
}
