using System;
using System.Reflection.Metadata.Ecma335;
using P04.Recharge.Models.Interfaces;

namespace P04.Recharge.Models;

public class RechargeStation : IStation
{
    private int _capacity;
    private int _current;
    public RechargeStation(int capacity)
    {
        _capacity = capacity;
        _current = 0;
    }

    public int Capacity
    {
        get => _capacity;
    }
    public int Current
    {
        get => _current;
    }

    public void Charge(IRechargeable rechargeable)
    {
        _current++;
        rechargeable.Recharge();
    }

    public void Dismount()
    {
        _current--;
    }
}
