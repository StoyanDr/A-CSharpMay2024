using System.Collections.Specialized;

namespace EstateAgency;

public class EstateAgency
{
    private int capacity;
    private List<RealEstate> realEstates;

    public EstateAgency(int capacity)
    {
        this.capacity = capacity;
        realEstates = new();
    }

    public int Capacity { get => capacity; set => capacity = value; }
    public List<RealEstate> RealEstates { get => realEstates; set => realEstates = value; }
    public int Count { get => realEstates.Count;}
    public void AddRealEstate(RealEstate realEstate)
    {
        if (Count == capacity) return;
        string address = realEstate.Address;
        for (int i = 0; i < realEstates.Count; i++)
        {
            if (realEstates[i].Address == address) return;
        }
        realEstates.Add(realEstate);
    }
    public bool RemoveRealEstate(string address)
    {
        for(int i = 0; i < realEstates.Count; i++)
        {
            if (realEstates[i].Address == address)
            {
                realEstates.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
    public List<RealEstate> GetRealEstates(string postalCode)
    {
        List<RealEstate> list = new();
        foreach(var item in realEstates)
        {
            if(item.PostalCode == postalCode)
                list.Add(item);
        }
        return list;
    }
    public RealEstate GetCheapest()
    {
        RealEstate cheapest = realEstates[0];
        for(int i = 1; i < realEstates.Count; i++)
        {
            if (realEstates[i].Price < cheapest.Price)
                cheapest = realEstates[i];
        }
        return cheapest;
    }
    public double GetLargest()
    {
        RealEstate largest = realEstates[0];
        for (int i = 1; i < realEstates.Count; i++)
        {
            if (realEstates[i].Size > largest.Size)
                largest = realEstates[i];
        }
        return largest.Size;
    }
    public string EstateReport()
    {
        string s = "";
        foreach(var item in realEstates)
        {
            s += item.ToString() + Environment.NewLine;
        }
        return s;
    }
}
