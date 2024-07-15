using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models;

public class Pet : IBirthdayable
{
    public Pet(string name, string birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public string Name { get; set; }
    public string BirthDate { get; set; }
}
