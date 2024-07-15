using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models;

namespace Telephony;

public class StartUp
{
    static void Main()
    {
        StationaryPhone phone = new();
        Smartphone smartphone = new();
        string[] numbers = Console.ReadLine().Split();
        string[] sites = Console.ReadLine().Split();
        foreach (string s in numbers)
        {
            try
            {
                if (s.Length == 7) phone.Call(s);
                else smartphone.Call(s);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        foreach (string s in sites)
        {
            try
            {
                smartphone.Browse(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
