﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Detail_Printer.Models.Interfaces;

public interface IEmployee
{
    string Name { get; set; }
    void GetDetails();
}
