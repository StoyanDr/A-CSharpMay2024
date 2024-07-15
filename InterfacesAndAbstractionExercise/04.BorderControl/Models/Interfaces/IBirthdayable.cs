using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models.Interfaces;

public interface IBirthdayable
{
    string Name { get; set; }
    string BirthDate { get; set; }
}
