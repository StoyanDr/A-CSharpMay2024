using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models.Interfaces;

public interface ICar
{
    public string Model { get; set; }
    public string Color { get; set; }
    public void Start();
    public void Stop();
}
