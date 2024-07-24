using P03.Detail_Printer.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace P03.DetailPrinter;

public class DetailsPrinter
{
    private IList<IEmployee> employees;

    public DetailsPrinter(IList<IEmployee> employees)
    {
        this.employees = employees;
    }
    public void PrintDetails()
    {
        foreach (Employee employee in this.employees)
        {
            employee.GetDetails();
        }
    }
}
